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
		public Settings ()
		{
			InitializeComponent ();
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			LibraryPathTextBox.Text = PartsManager.Properties.Settings.Default.LibraryPath;
		}

		private void UpdateButton_Click ( object sender, EventArgs e )
		{
			
		}

		private void LibraryPathChangeButton_Click ( object sender, EventArgs e )
		{
			folderBrowserDialog.ShowDialog ();
			if ( folderBrowserDialog.SelectedPath != String.Empty )
			{
				LibraryPathTextBox.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void CancelButton_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

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

				dbConnection.Close ();
			}
		}

		private void DatasheetPathChangeButton_Click ( object sender, EventArgs e )
		{
			folderBrowserDialog.ShowDialog ();
			if ( folderBrowserDialog.SelectedPath != String.Empty )
			{
				PartsPathTextBox.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void DataBaseFileChangeButton_Click ( object sender, EventArgs e )
		{
			openFileDialog.Filter = "SQLite files (*.sqlite)|*.sqlite";
			openFileDialog.ShowDialog ();
			if (  openFileDialog.FileName != String.Empty )
			{
				DataBasePathTextBox.Text = openFileDialog.FileName;
			}
		}

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
