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
	public partial class UrlEdit : Form
	{
		private string PartID;
		private bool Edit;

		public UrlEdit ( string Part )
		{
			InitializeComponent ();
			this.Edit = false;
			this.PartID = Part;
		}

		/*public UrlEdit ( Part_t Part, Link_t Link )
		{
			InitializeComponent ();
			
			this.MPartTextBox.Text = Link.Mpart;
			this.MPartTextBox.Enabled = false;
			this.ProviderTextBox.Text = Link.Provider;
			this.UrlTextBox.Name = Link.Url;

			this.Part = Part;
			this.Edit = true;
		}*/

		private void CancelButton_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void OkButton_Click ( object sender, EventArgs e )
		{

			// Connect to the database.
			var context = new DataContext (
				new SQLiteConnection (
					@"Data Source=" + Properties.Settings.Default.DatabasePath
				)
			);
			
			Table<Link_t> links = context.GetTable<Link_t> ();

			// Check whether we're inserting or updating database.
			if ( Edit )
			{

			}
			else
			{
				Link_t link = new Link_t
				{
					PartID = this.PartID,
					Mpart = MPartTextBox.Text,
					Provider = ProviderTextBox.Text,
					Url = UrlTextBox.Text
				};
				links.InsertOnSubmit ( link );
			}

			// Save data.
			context.SubmitChanges ();

			// Close the form.
			this.Close ();
		}
	}
}
