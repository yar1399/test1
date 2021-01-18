using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
	public class networkshoppingdetailsgResult
	{
		[Key]
		public System.Nullable<long> idnetwork { get; set; }

		public string networkname { get; set; }

		public string imgcover { get; set; }

		public string imgavatar { get; set; }

		public System.Nullable<int> idshoppingtype { get; set; }

		public string nameshoppingtype { get; set; }

		public string geo { get; set; }

		public string networkshoppingtell { get; set; }

		public System.Nullable<long> idnetworkshoppingtell { get; set; }

		public string description { get; set; }


		public System.Nullable<int> idproductshoppingtype { get; set; }


		public System.Nullable<int> isview { get; set; }


		public System.Nullable<int> countermenu { get; set; }


		public System.Nullable<int> counterfollower { get; set; }

		public System.Nullable<int> counterrequest { get; set; }


		public String registertell { get; set; }


		public String networktell { get; set; }

		public System.Nullable<Boolean> blockuser { get; set; }

		public System.Nullable<int> idstate { get; set; }

		public System.Nullable<int> idtype { get; set; }

	}
}
