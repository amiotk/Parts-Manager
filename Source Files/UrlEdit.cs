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
		private Link_t Link;

		/// <summary>
		/// Class default constructor.
		/// </summary>
		/// <param name="Part">Part ID</param>
		public UrlEdit ( string Part )
		{
			InitializeComponent ();
			this.Edit = false;
			this.PartID = Part;
		}

		/// <summary>
		/// Extended constructor. Used for creating form for edit URL rather than creating new one.
		/// </summary>
		/// <param name="Part">Part ID</param>
		/// <param name="Link">Object containing data to initialise form fields.</param>
		public UrlEdit ( string Part, Link_t Link )
		{
			InitializeComponent ();
			
			this.MPartTextBox.Text = Link.Mpart;
			this.MPartTextBox.Enabled = false;
			this.ProviderTextBox.Text = Link.Provider;
			this.UrlTextBox.Text = Link.Url;

			this.PartID = Part;
			this.Edit = true;
			this.Link = Link;
		}

		/// <summary>
		/// Closes form without saving changes.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
		private void CancelButton_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		/// <summary>
		/// Saves data and closes form.
		/// </summary>
		/// <param name="sender">Sender</param>
		/// <param name="e">Event arguments</param>
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
				var linksSet = from link in context.GetTable<Link_t> ()
							   where link.ID == Link.ID
							   select link;

				foreach ( var link in linksSet )
				{
					link.Provider = ProviderTextBox.Text;
					link.Url = UrlTextBox.Text;
				}
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
