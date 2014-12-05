using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PartsManager.Source_Files
{
	public partial class Settings : Form
	{
		/// <summary>
		/// Class default constructor.
		/// </summary>
		public Settings ()
		{
			InitializeComponent ();
		}

		/// <summary>
		/// Opens folder select dialog box and saves selected path as a path to KiCAD library.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void LibraryPathChangeButton_Click ( object sender, EventArgs e )
		{
			folderBrowserDialog.ShowDialog ();
			if ( folderBrowserDialog.SelectedPath != String.Empty )
			{
				LibraryPathTextBox.Text = folderBrowserDialog.SelectedPath;
			}
		}

		/// <summary>
		/// Closes settings window without saving any changes.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void CancelButton_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		/// <summary>
		/// Creates new database file in directory selected by user.
		/// Creates whole database structure (tables) without inserting any data.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void NewDataBaseButton_Click ( object sender, EventArgs e )
		{
			saveFileDialog.Filter = "SQLite files (*.sqlite)|*.sqlite";
			saveFileDialog.ShowDialog ();

			if ( saveFileDialog.FileName != String.Empty )
			{
				Properties.Settings.Default.DatabasePath = saveFileDialog.FileName;
				DataBasePathTextBox.Text = Properties.Settings.Default.DatabasePath;

				SQLiteConnection.CreateFile ( Properties.Settings.Default.DatabasePath );

				SQLiteConnection dbConnection = new SQLiteConnection ( 
					"Data Source=" + 
					Properties.Settings.Default.DatabasePath + 
					";Version=3;" 
				);

				dbConnection.Open ();

				new SQLiteCommand (
					"create table COMPONENTS (ID varchar(20) PRIMARY KEY, STOCK UNSIGNED BIG INT, DESCRIPTION varchar(50))",
					dbConnection
				).ExecuteNonQuery ();

				new SQLiteCommand (
					"create table LINKS ( ID INTEGER PRIMARY KEY, MPART varchar(30), PARTID varchar(20), URL varchar(250), PROVIDER varchar(20))",
					dbConnection
				).ExecuteNonQuery ();

				dbConnection.Close ();
			}
		}

		/// <summary>
		/// Opens folder select dialog box and saves selected directory path as datasheets path.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void DatasheetPathChangeButton_Click ( object sender, EventArgs e )
		{
			folderBrowserDialog.ShowDialog ();
			if ( folderBrowserDialog.SelectedPath != String.Empty )
			{
				PartsPathTextBox.Text = folderBrowserDialog.SelectedPath;
			}
		}

		/// <summary>
		/// Opens file select dialog box and saves selected path as database path.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void DataBaseFileChangeButton_Click ( object sender, EventArgs e )
		{
			openFileDialog.Filter = "SQLite files (*.sqlite)|*.sqlite";
			openFileDialog.ShowDialog ();
			if (  openFileDialog.FileName != String.Empty )
			{
				DataBasePathTextBox.Text = openFileDialog.FileName;
			}
		}

		/// <summary>
		/// Saves settings, closes form and returns to main window.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void OkButton_Click ( object sender, EventArgs e )
		{
			Properties.Settings.Default.LibraryPath = LibraryPathTextBox.Text;
			Properties.Settings.Default.DatasheetPath = PartsPathTextBox.Text;
			Properties.Settings.Default.DatabasePath = DataBasePathTextBox.Text;
			
			Properties.Settings.Default.Save ();

			this.Close ();
		}

	}
}
