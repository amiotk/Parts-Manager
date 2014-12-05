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

namespace PartsManager.Source_Files
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainForm ()
		{
			InitializeComponent ();
		}

		/// <summary>
		/// States of KiCAD library file parser.
		/// </summary>
		private enum ReadStates
		{
			Name,
			Package,
			ID
		}

		/// <summary>
		/// Opens Setting window.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void settingsToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			Settings settings = new Settings ();
			settings.ShowDialog ();
		}

		/// <summary>
		/// Rescans Library directory and update parts DataGridView.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void reloadToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			// Clear previous data just in case when reload is clicked twice.
			partsDataGridView.Columns.Clear ();

			// Find all library's elements.
			List<Part_t> Parts = librariesParse ();
			
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
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void dataGridView1_CellEnter ( object sender, DataGridViewCellEventArgs e )
		{
			// Update details view controls.
			PartNameLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 1 ].FormattedValue.ToString ();
			PartNumberLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 0 ].FormattedValue.ToString ();
			PackageNameLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 2 ].FormattedValue.ToString ();
			StockTextBox.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 3 ].FormattedValue.ToString ();
			ModuleLabel.Text = partsDataGridView.Rows[ e.RowIndex ].Cells[ 4 ].FormattedValue.ToString ();
			string directory = datasheetDirectory ( partsDataGridView.Rows[ e.RowIndex ].Cells[ 0 ].Value.ToString () ); 
			DatasheetLink.Text = Path.GetFileName ( directory );
			DatasheetLink.Links[ 0 ].LinkData = directory;
			
			// Update Description box using data from database.
			DescriptionTextBox.Clear ();

			var context = new DataContext (
				new SQLiteConnection (
					@"Data Source=" + Properties.Settings.Default.DatabasePath
				)
			);

			var parts = from part in context.GetTable<Components> ()
						where part.ID == PartNumberLabel.Text
						select part;

			foreach ( var part in parts )
			{
				DescriptionTextBox.Text = part.Description;
			}

			// Fill URL combo box.
			UrlComboBox.DataSource = null;
			UrlData_Update ();
		}
		
		/// <summary>
		/// Closes the app.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
		{
			Application.Exit ();
		}

		/// <summary>
		/// Opens datasheet PDF.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void DatasheetLink_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e )
		{
			if ( e.Link.LinkData != null )
			{
				System.Diagnostics.Process.Start ( @e.Link.LinkData.ToString () );
			}
		}

		/// <summary>
		/// Saves data in database.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void SaveButton_Click ( object sender, EventArgs e )
		{
			var context = new DataContext (
				new SQLiteConnection (
					@"Data Source=" + Properties.Settings.Default.DatabasePath
				)
			);

			Table<Components> components = context.GetTable<Components> ();

			// Check whether part is already in database or not.
			// If part exist then update data, otherwise insert new entity.
			if ( components.Any ( x => x.ID == PartNumberLabel.Text ) )
			{
				var parts = from part in context.GetTable<Components> ()
							where part.ID == PartNumberLabel.Text
							select part;

				foreach ( var part in parts )
				{
					part.Stock = Convert.ToInt64 ( StockTextBox.Text );
					part.Description = DescriptionTextBox.Text;
				}
			}
			else
			{
				Components part = new Components
				{
					ID = PartNumberLabel.Text,
					Stock = Convert.ToInt64 ( StockTextBox.Text ),
					Description = DescriptionTextBox.Text
				};
				components.InsertOnSubmit ( part );
			}

			// Save changes in database.
			context.SubmitChanges ();

			// Update the dataGridView.
			partsDataGridView.Rows[ partsDataGridView.CurrentCell.RowIndex ].Cells[ 3 ].Value = StockTextBox.Text;
			
		}

		/// <summary>
		/// Visits part provider's website.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void GoUrlButton_Click ( object sender, EventArgs e )
		{
			string value = ( ( KeyValuePair<Link_t, string> )UrlComboBox.SelectedItem ).Key.Url;
			System.Diagnostics.Process.Start ( value );
		}

		/// <summary>
		/// Opens URL creating form.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void AddUrlButton_Click ( object sender, EventArgs e )
		{
			UrlEdit urlForm = new UrlEdit ( PartNumberLabel.Text );
			urlForm.ShowDialog ();

			// Refresh changes.
			UrlData_Update ();
		}

		/// <summary>
		/// Opens URL editing form.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event argument</param>
		private void EditUrlButton_Click ( object sender, EventArgs e )
		{
			// Extract URL object from selected combobox item.
			Link_t url = ( ( KeyValuePair<Link_t, string> )UrlComboBox.SelectedItem ).Key;

			// Open the form.
			UrlEdit urlForm = new UrlEdit ( PartNumberLabel.Text, url );
			urlForm.ShowDialog ();

			// Refresh changes.
			UrlData_Update ();
		}

		/// <summary>
		/// Deletes URL from database.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void DeleteUrlButton_Click ( object sender, EventArgs e )
		{
			// Extract URL object from selected combobox item.
			Link_t url = ( ( KeyValuePair<Link_t, string> )UrlComboBox.SelectedItem ).Key;

			// Connect to the database.
			var context = new DataContext (
				new SQLiteConnection (
					@"Data Source=" + Properties.Settings.Default.DatabasePath
				)
			);

			Table<Link_t> links = context.GetTable<Link_t> ();

			var linksSet = from link in context.GetTable<Link_t> ()
							where link.ID == url.ID
							select link;

			foreach ( var link in linksSet )
			{
				links.DeleteOnSubmit ( link );
			}

			// Save data.
			context.SubmitChanges ();

			// Refresh changes.
			UrlData_Update ();
		}

		/// <summary>
		/// Updates URL data in details view.
		/// </summary>
		private void UrlData_Update ()
		{
			var context = new DataContext (
				new SQLiteConnection (
					@"Data Source=" + Properties.Settings.Default.DatabasePath
				)
			);

			var urls = from url in context.GetTable<Link_t> ()
					   where url.PartID == PartNumberLabel.Text
					   select url;

			if ( urls.Any ( x => x.PartID == PartNumberLabel.Text ) )
			{
				Dictionary<Link_t, string> comboboxSource = new Dictionary<Link_t, string> ();

				foreach ( var url in urls )
				{
					comboboxSource.Add ( url, url.Provider + " (" + url.Mpart + ")" );
				}

				UrlComboBox.DataSource = new BindingSource ( comboboxSource, null );
				UrlComboBox.DisplayMember = "Value";
				UrlComboBox.ValueMember = "Key";

				GoUrlButton.Enabled = true;
				EditUrlButton.Enabled = true;
				DeleteUrlButton.Enabled = true;
			}
			else
			{
				GoUrlButton.Enabled = false;
				EditUrlButton.Enabled = false;
				DeleteUrlButton.Enabled = false;
			}
		}

		/// <summary>
		/// Scans Library directory and parses files to extract parts.
		/// </summary>
		/// <returns>List of founded parts</returns>
		private List<Part_t> librariesParse ()
		{
			List<Part_t> parts = new List<Part_t> ();
			ReadStates state = ReadStates.Name;
			Part_t part = new Part_t ( "ID", "VAL", "PACKAGE", 0, "MODULE" );

			var context = new DataContext (
				new SQLiteConnection (
					@"Data Source=" + Properties.Settings.Default.DatabasePath
				)
			);

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

									var dbParts = from dbPart in context.GetTable<Components> ()
												  where dbPart.ID == part.ID
												  select dbPart;

									foreach ( var dbPart in dbParts )
									{
										part.Stock = dbPart.Stock;
									}

									parts.Add ( new Part_t ( part.ID, part.Value, part.Package, part.Stock, Path.GetFileName ( f.File ) ) );
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

		/// <summary>
		/// Finds part's datasheet and returns path to it.
		/// </summary>
		/// <param name="PartID">ID of the part</param>
		/// <returns>Path to the datasheet</returns>
		private string datasheetDirectory ( string PartID )
		{
			try
			{
				var files = from file in Directory.EnumerateFiles ( @Properties.Settings.Default.DatasheetPath, "*.pdf", SearchOption.AllDirectories )
							where file.Contains ( PartID )
							select new
							{
								File = file
							};

				foreach ( var f in files )
				{
					return f.File;
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
			return string.Empty;
		}

	}
}
