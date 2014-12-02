using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;

namespace PartsManager
{
	[Table ( Name = "INSTOCK" )]
	class InStock
	{
		[Column ( Name = "ID" )]
		public string ID { get; set; }

		[Column ( Name = "Quantity" )]
		public long Quantity { get; set; }
	}
}
