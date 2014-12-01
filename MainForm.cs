using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Linq;

namespace PartsManager
{
	public partial class MainForm : Form
	{
		public MainForm ()
		{
			InitializeComponent ();
		}

		private enum ReadStates
		{
			Name,
			Package,
			ID
		}

		private void settingsToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			Settings settings = new Settings ();
			settings.ShowDialog ();
		}

		private void reloadToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			// Clear previous data just in case when reload is clicked twice.
			partsDataGridView.Columns.Clear ();

			// Find all library's elements.
			List<Part> Parts = librariesParse ();
			
			// Add founded parts to dataGridView
			partsDataGridView.DataSource = Parts.OrderBy ( o => o.ID ).ToList ();

			// Format grid view.
			partsDataGridView.Columns[ 0 ].Width = ( partsDataGridView.Width / 10 ) * 1;
			partsDataGridView.Columns[ 1 ].Width = ( partsDataGridView.Width / 10 ) * 3;
			partsDataGridView.Columns[ 2 ].Width = ( partsDataGridView.Width / 10 ) * 3;
			partsDataGridView.Columns[ 3 ].Width = ( partsDataGridView.Width / 10 ) * 1;
			partsDataGridView.Columns[ 4 ].Visible = false;

			// Enable details view. 
			DetailsGroupBox.Enabled = true;
		}

		/// <summary>
		/// Fills details about clicked part.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void dataGridView1_CellEnter ( object sender, DataGridViewCellEventArgs e )
		{
			PartNameLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 1 ].FormattedValue.ToString ();
			PartNumberLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 0 ].FormattedValue.ToString ();
			PackageNameLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 2 ].FormattedValue.ToString ();
			QuantityTextBox.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 3 ].FormattedValue.ToString ();
			ModuleLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 4 ].FormattedValue.ToString ();
			string directory = datasheetDirectory ( partsDataGridView.Rows[ e.RowIndex ].Cells[ 0 ].Value.ToString () ); 
			DatasheetLink.Text = Path.GetFileName ( directory );
			DatasheetLink.Links[ 0 ].LinkData = directory;
			DescriptionTextBox.Clear ();

			/*var connection = new SQLiteConnection (	@Properties.Settings.Default.DatabasePath );
			var context = new DataContext ( connection );

			var stocks = context.GetTable<InStock> ();
			foreach ( var stock in stocks )
			{
				DescriptionTextBox.Text = stock.Quantity.ToString ();
			}*/


			SQLiteConnection dbConnection = new SQLiteConnection (
				"Data Source=" +
				Properties.Settings.Default.DatabasePath +
				";Version=3;"
			);

			dbConnection.Open ();
			SQLiteDataReader reader = new SQLiteCommand (
				"select * from DESCRIPTIONS where ID == " + PartNumberLabel.Text,
				dbConnection
			).ExecuteReader ();

			while ( reader.Read () )
			{
				DescriptionTextBox.Text = reader[ "DESCRIPTION" ].ToString ();
			}

			dbConnection.Close ();
		}
		
		/// <summary>
		/// Closes the app.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			Application.Exit ();
		}

		/// <summary>
		/// Scans Library directory and parses files to extract parts.
		/// </summary>
		/// <returns>List of founded parts.</returns>
		private List<Part> librariesParse ()
		{
			List<Part> parts = new List<Part> ();
			ReadStates state = ReadStates.Name;
			Part part = new Part ( "ID", "VAL", "PACKAGE", 0, "MODULE" );
			SQLiteConnection dbConnection = new SQLiteConnection (
				"Data Source=" +
				Properties.Settings.Default.DatabasePath +
				";Version=3;"
			);

			dbConnection.Open ();
			
			try
			{
				var files = from file in Directory.EnumerateFiles ( @Properties.Settings.Default.LibraryPath, "*.lib", SearchOption.AllDirectories )
							from line in File.ReadLines ( file )
							select new
							{
								File = file,
								Line = line
							};

				foreach ( var f in files )
				{
					string[] items = f.Line.Split ( ' ' );

					if ( f.Line.Contains ( "ENDDEF" ) )
					{
						state = ReadStates.Name;
					}
					else
					{
						switch ( state )
						{
							case ReadStates.Name:
								if ( f.Line.Contains ( "DEF" ) )
								{
									part.Value = items[ 1 ];
									state = ReadStates.Package;
								}
								break;
							case ReadStates.Package:
								if ( f.Line.Contains ( "F2" ) )
								{
									part.Package = items[ 1 ].Trim ( new Char[] { '"' } );
									state = ReadStates.ID;
								}
								break;
							case ReadStates.ID:
								if ( f.Line.Contains ( "Part" ) )
								{
									part.ID = items[ 1 ].Trim ( new Char[] { '"' } );
									part.Stock = 0;

									SQLiteDataReader reader = new SQLiteCommand (
										"select * from INSTOCK where ID == " + part.ID,
										dbConnection
									).ExecuteReader ();

									while ( reader.Read () )
									{
										part.Stock = ( long )reader[ "QUANTITY" ];
									}

									parts.Add ( new Part ( part.ID, part.Value, part.Package, part.Stock, Path.GetFileName ( f.File ) ) );
								}
								break;
						}
					}
				}
			}
			catch ( UnauthorizedAccessException UAEx )
			{
				Console.WriteLine ( UAEx.Message );
			}
			catch ( PathTooLongException PathEx )
			{
				Console.WriteLine ( PathEx.Message );
			}

			dbConnection.Close ();

			return parts;
		}

		/// <summary>
		/// Finds part's datasheet and returns path to it.
		/// </summary>
		/// <param name="PartID">ID of the part.</param>
		/// <returns>Path to the datasheet.</returns>
		private string datasheetDirectory ( string PartID )
		{
			try
			{
				var files = from file in Directory.EnumerateFiles ( @Properties.Settings.Default.DatasheetPath, "*.pdf", SearchOption.AllDirectories )
							where file.Contains( PartID )
							select new
							{
								File = file
							};

				foreach (var f in files)
				{
					return f.File;
				}
			}
			catch (UnauthorizedAccessException UAEx)
			{
				Console.WriteLine(UAEx.Message);
			}
			catch (PathTooLongException PathEx)
			{
				Console.WriteLine(PathEx.Message);
			}
			return string.Empty;
		}

		/// <summary>
		/// Opens datasheet PDF.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void DatasheetLink_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( e.Link.LinkData != null )
			{
				System.Diagnostics.Process.Start ( @e.Link.LinkData.ToString () );
			}
		}
	}
}
