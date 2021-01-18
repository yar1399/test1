using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{

    [Keyless]
    public class networksettingusergetResult
	{

        public Nullable<int>   idsetting { get; set; }
        public string namesetting { get; set; }
        public Nullable<long> idnetworksettinguser { get; set; }
        public Nullable<int> isactive { get; set; }


    }
}
