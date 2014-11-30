using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			settings.Show ();
		}

		private void reloadToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			// Clear previous data just in case when reload is clicked twice.
			partsDataGridView.Columns.Clear ();

			// Find all library's elements.
			List<Part> Parts = librariesParse ();
			
			// Add founded parts to dataGridView
			partsDataGridView.DataSource = Parts.OrderBy ( o => o.ID ).ToList ();
			
			// Add Info buttons
			DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn ();
			partsDataGridView.Columns.Add ( buttonColumn );
			buttonColumn.Width = 50 ;
			buttonColumn.Text = "More";
			buttonColumn.UseColumnTextForButtonValue = true;

			// Format grid view.
			partsDataGridView.Columns[ 0 ].Width = ( partsDataGridView.Width / 10 ) * 1;
			partsDataGridView.Columns[ 1 ].Width = ( partsDataGridView.Width / 10 ) * 3;
			partsDataGridView.Columns[ 2 ].Width = ( partsDataGridView.Width / 10 ) * 3;
			partsDataGridView.Columns[ 3 ].Width = ( partsDataGridView.Width / 10 ) * 1;
		}

		private void partsDataGridView_CellClick ( object sender, DataGridViewCellEventArgs e )
		{
			PartNameLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 1 ].FormattedValue.ToString ();
			PartNumberLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 0 ].FormattedValue.ToString ();
			PackageNameLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 2 ].FormattedValue.ToString ();
			QuantityTextBox.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 3 ].FormattedValue.ToString ();
			DatasheetLink.Text = Path.GetFileName ( datasheetDirectory ( partsDataGridView.Rows[ e.RowIndex ].Cells[ 0 ].Value.ToString () ) );
		}

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
			Part part = new Part ( "ID", "VAL", "PACKAGE", 0 );

			try
			{
				var files = from file in Directory.EnumerateFiles ( @Properties.Settings.Default.LibraryDirectory, "*.lib", SearchOption.AllDirectories )
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
									parts.Add ( new Part ( part.ID, part.Value, part.Package, 0 ) );
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

			return parts;
		}

		private string datasheetDirectory ( string PartID )
		{
			try
			{
				var files = from file in Directory.EnumerateFiles(@Properties.Settings.Default.DatasheetDirectory, "*.pdf", SearchOption.AllDirectories)
							where file.Contains( PartID )
							select new
							{
								File = file
							};

				foreach (var f in files)
				{
					return f.File;
					//Console.WriteLine("{0}\t{1}", f.File, f.Line);
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
	}
}
