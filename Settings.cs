using System;
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
	public partial class Settings : Form
	{
		public Settings ()
		{
			InitializeComponent ();
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			textBox1.Text = PartsManager.Properties.Settings.Default.LibraryDirectory;
		}

		private void UpdateButton_Click ( object sender, EventArgs e )
		{
			Properties.Settings.Default.LibraryDirectory = textBox1.Text;
			Properties.Settings.Default.Save ();
		}

		private void SelectButton_Click ( object sender, EventArgs e )
		{
			LibraryFolderBrowserDialog.ShowDialog ();
			Properties.Settings.Default.LibraryDirectory = LibraryFolderBrowserDialog.SelectedPath;
			
		}

	}
}
