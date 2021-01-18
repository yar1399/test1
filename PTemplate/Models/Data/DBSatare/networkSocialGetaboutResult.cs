using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkSocialGetaboutResult
    {

			private long _id;

			private string _iduser;

			private System.Nullable<byte> _idnetworktype;

			private System.Nullable<System.DateTime> _birthday;

			private System.Nullable<bool> _sex;

			private string _name;

			private string _discription;

			private string _phonenumber;

			private string _namecity;

			private string _nickname;

			public networkSocialGetaboutResult()
			{
			}
		[Key]
		public long id
			{
				get
				{
					return this._id;
				}
				set
				{
					if ((this._id != value))
					{
						this._id = value;
					}
				}
			}

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

			public System.Nullable<byte> idnetworktype
			{
				get
				{
					return this._idnetworktype;
				}
				set
				{
					if ((this._idnetworktype != value))
					{
						this._idnetworktype = value;
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

			public string nickname
			{
				get
				{
					return this._nickname;
				}
				set
				{
					if ((this._nickname != value))
					{
						this._nickname = value;
					}
				}
			}
		}
	}
