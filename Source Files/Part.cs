using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsManager.Source_Files
{
	/// <summary>
	/// Class of KiCAD element entity.
	/// </summary>
	class Part_t : INotifyPropertyChanged
	{
		/// <summary>
		/// ID of the component.
		/// </summary>
		private string fieldID;

		/// <summary>
		/// Value of the component.
		/// </summary>
		private string fieldValue;

		/// <summary>
		/// Package of the component.
		/// </summary>
		private string fieldPackage;

		/// <summary>
		/// Number of elements in stock.
		/// </summary>
		private long fieldStock;

		/// <summary>
		/// Library file when component exist.
		/// </summary>
		private string fieldModule;

		/// <summary>
		/// Event fired when any property of component change.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Main constructor of the class. 
		/// </summary>
		/// <param name="ID">ID of new component.</param>
		/// <param name="Value">Value of new component.</param>
		/// <param name="Package">Package of new component.</param>
		/// <param name="Stock">Quantity of elements.</param>
		public Part_t ( string ID, string Value, string Package, long Stock, string Module )
		{
			fieldID = ID;
			fieldValue = Value;
			fieldPackage = Package;
			fieldStock = Stock;
			fieldModule = Module;
		}

		/// <summary>
		/// Gets/Sets the ID.
		/// </summary>
		public string ID
		{
			get { return fieldID; }
			set
			{
				fieldID = value;
				this.NotifyPropertyChanged ( "ID" );
			}
		}

		/// <summary>
		/// Gets/Sets the Value.
		/// </summary>
		public string Value
		{
			get { return fieldValue; }
			set
			{
				fieldValue = value;
				this.NotifyPropertyChanged ( "Value" );
			}
		}

		/// <summary>
		/// Gets/Sets the Package.
		/// </summary>
		public string Package
		{
			get { return fieldPackage; }
			set
			{
				fieldPackage = value;
				this.NotifyPropertyChanged ( "Package" );
			}
		}

		/// <summary>
		/// Magazine stock.
		/// </summary>
		public long Stock
		{
			get { return fieldStock; }
			set
			{
				fieldStock = value;
				this.NotifyPropertyChanged ( "Info" );
			}
		}

		/// <summary>
		/// Gets/Sets the Module.
		/// </summary>
		public string Module
		{
			get { return fieldModule; }
			set
			{
				fieldModule = value;
				this.NotifyPropertyChanged ( "Package" );
			}
		}

		/// <summary>
		/// Fires event of changing component's property.
		/// </summary>
		/// <param name="Name">Name of changed property.</param>
		private void NotifyPropertyChanged ( string Name )
		{
			if ( PropertyChanged != null )
				PropertyChanged ( this, new PropertyChangedEventArgs ( Name ) );
		}
	}
}
