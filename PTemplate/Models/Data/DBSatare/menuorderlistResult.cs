using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
	public class menuorderlistResult
	{
		[Key]
		public long idnetwork { get; set; }
	    public string namenetwork { get; set; }
		public byte idnetworktype { get; set; }
		public string namenetworktype { get; set; }
			public string registeredtell { get; set; }
			public string tell { get; set; }
			public string geo { get; set; }
			public Decimal summoney { get; set; }
			public string imgpathavatar { get; set; }
			public Guid idmenuorder { get; set; }
			public Int32 counterorder { get; set; }
			public byte idstatetype { get; set; }
			public string namestatetype { get; set; }
			public string firstlastname { get; set; }
			public string nickname { get; set; }
			//public string telluser { get; set; }
	}
}
