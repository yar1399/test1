using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class UserProfileGat
    {

		private long _Id;

		private long _Idnetwork;

		private System.Nullable<bool> _Idsex;

		private System.Nullable<bool> _Isactive;

		private string _lastfirstname;

		private string _namenetwork;

		private string _phonenumber;

		private System.Nullable<DateTime> _birthday;

		private System.Nullable<int> _city;

		private System.Nullable<int> _region;

		private System.Nullable<int> _county;

		private string _description;

		private string _pathavatar;

		private string _pathcover;

		private string _namecity;
		private string _namecounty;
		private string _nameprovince;

		public UserProfileGat()
		{
		}


		[Key]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}

		
		public long Idnetwork
		{
			get
			{
				return this._Idnetwork;
			}
			set
			{
				if ((this._Idnetwork != value))
				{
					this._Idnetwork = value;
				}
			}
		}

		
		public System.Nullable<bool> Idsex
		{
			get
			{
				return this._Idsex;
			}
			set
			{
				if ((this._Idsex != value))
				{
					this._Idsex = value;
				}
			}
		}

	
		public System.Nullable<bool> Isactive
		{
			get
			{
				return this._Isactive;
			}
			set
			{
				if ((this._Isactive != value))
				{
					this._Isactive = value;
				}
			}
		}

		
		public string lastfirstname
		{
			get
			{
				return this._lastfirstname;
			}
			set
			{
				if ((this._lastfirstname != value))
				{
					this._lastfirstname = value;
				}
			}
		}


		public string namenetwork
		{
			get
			{
				return this._namenetwork;
			}
			set
			{
				if ((this._namenetwork != value))
				{
					this._namenetwork = value;
				}
			}
		}


		public string phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if ((this._phonenumber != value))
				{
					this._phonenumber = value;
				}
			}
		}

		
		public Nullable< DateTime> birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if ((this._birthday != value))
				{
					this._birthday = value;
				}
			}
		}

	
	
		
		public System.Nullable<int> city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this._city = value;
				}
			}
		}

		
		public System.Nullable<int> region
		{
			get
			{
				return this._region;
			}
			set
			{
				if ((this._region != value))
				{
					this._region = value;
				}
			}
		}
		
		public System.Nullable<int> county
		{
			get
			{
				return this._county;
			}
			set
			{
				if ((this._county != value))
				{
					this._county = value;
				}
			}
		}

	
	

	
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this._description = value;
				}
			}
		}


		public string pathavatar
		{
			get
			{
				return this._pathavatar;
			}
			set
			{
				if ((this._pathavatar != value))
				{
					this._pathavatar = value;
				}
			}
		}

		public string pathcover
		{
			get
			{
				return this._pathcover;
			}
			set
			{
				if ((this._pathcover != value))
				{
					this._pathcover = value;
				}
			}
		}



		public string namecity
		{
			get
			{
				return this._namecity;
			}
			set
			{
				if ((this._namecity != value))
				{
					this._namecity = value;
				}
			}
		}


		public string namecounty
		{
			get
			{
				return this._namecounty;
			}
			set
			{
				if ((this._namecounty != value))
				{
					this._namecounty = value;
				}
			}
		}


		public string nameprovince
		{
			get
			{
				return this._nameprovince;
			}
			set
			{
				if ((this._nameprovince != value))
				{
					this._nameprovince = value;
				}
			}
		}




	}
}
