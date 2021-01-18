using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
	public class shoppingnetworkmenugetResult
	{

		[Key]
		public Guid id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public Nullable<decimal> money { get; set; }
		public Nullable<decimal> moneyuser { get; set; }
		public string nameunit { get; set; }
		public Nullable<int> idunit { get; set; }
		public Nullable<DateTime> datestart { get; set; }
		public Nullable<DateTime> dateend { get; set; }
		public string path { get; set; }
		public Nullable<int> idcode { get; set; }
		public string message { get; set; }
		public Nullable<int> code { get; set; }


	}
}
