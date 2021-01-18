using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class profileuserGetResult
    {


			private string _iduser;

			private System.Nullable<System.DateTime> _birthday;

			private System.Nullable<bool> _sex;

			private string _name;

			private string _discription;

			private string _phonenumber;

			private System.Nullable<int> _idprovince;

			private string _nameprovince;

			private System.Nullable<int> _idcounty;

			private string _namecounty;

			private System.Nullable<int> _idcity;

			private string _namecity;

			public profileuserGetResult()
			{
			}
		[Key]
		public string iduser
			{
				get
				{
					return this._iduser;
				}
				set
				{
					if ((this._iduser != value))
					{
						this._iduser = value;
					}
				}
			}

			public System.Nullable<System.DateTime> birthday
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

			public System.Nullable<bool> sex
			{
				get
				{
					return this._sex;
				}
				set
				{
					if ((this._sex != value))
					{
						this._sex = value;
					}
				}
			}

			public string name
			{
				get
				{
					return this._name;
				}
				set
				{
					if ((this._name != value))
					{
						this._name = value;
					}
				}
			}

			public string discription
			{
				get
				{
					return this._discription;
				}
				set
				{
					if ((this._discription != value))
					{
						this._discription = value;
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

			public System.Nullable<int> idprovince
			{
				get
				{
					return this._idprovince;
				}
				set
				{
					if ((this._idprovince != value))
					{
						this._idprovince = value;
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

			public System.Nullable<int> idcounty
			{
				get
				{
					return this._idcounty;
				}
				set
				{
					if ((this._idcounty != value))
					{
						this._idcounty = value;
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

			public System.Nullable<int> idcity
			{
				get
				{
					return this._idcity;
				}
				set
				{
					if ((this._idcity != value))
					{
						this._idcity = value;
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
		}
	}
