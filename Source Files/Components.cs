using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PartsManager.Source_Files
{
	[Table ( Name = "COMPONENTS" )]
	class Components
	{
		[Column ( Name = "ID", IsPrimaryKey = true )]
		public string ID { get; set; }

		[Column ( Name = "STOCK" )]
		public long Stock { get; set; }

		[Column ( Name = "DESCRIPTION" )]
		public string Description { get; set; }
	}
}
