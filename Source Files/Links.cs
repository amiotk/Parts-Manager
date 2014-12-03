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
	[Table ( Name = "LINKS" )]
	class Link_t
	{
		[Column ( Name = "ID", IsPrimaryKey = true )]
		public int? ID { get; set; }

		[Column ( Name = "MPART" )]
		public string Mpart { get; set; }

		[Column ( Name = "PARTID" )]
		public string PartID { get; set; }

		[Column ( Name = "URL" )]
		public string Url { get; set; }

		[Column ( Name = "PROVIDER" )]
		public string Provider { get; set; }
	}
}
