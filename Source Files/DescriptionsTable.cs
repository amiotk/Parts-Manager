using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;

namespace PartsManager.Source_Files
{
	[Table ( Name = "DESCRIPTIONS" )]
	class DescriptionsTable
	{
		[Column ( Name = "ID" )]
		public string ID { get; set; }

		[Column ( Name = "DESCRIPTION" )]
		public string Description { get; set; }
	}

}
