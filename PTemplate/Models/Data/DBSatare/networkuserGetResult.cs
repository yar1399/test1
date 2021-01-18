using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkuserGetResult
    {


			private string _cover;

			private string _avatar;

			private string _iduser;

			private System.Nullable<byte> _idstate;

			private System.Nullable<long> _idnetworkBase;

			private System.Nullable<byte> _idtype;

			private string _nicname2;

			private System.Nullable<long> _rank;

			private System.Nullable<byte> _idtypenetwork;
		    private System.Nullable<Int32> _idtypeshopping;

		private string _name;

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

		public System.Nullable<Int32> idtypeshopping
		{
			get
			{
				return this._idtypeshopping;
			}
			set
			{
				if ((this._idtypeshopping != value))
				{
					this._idtypeshopping = value;
				}
			}
		}

		public System.Nullable<byte> idtypenetwork
		{
			get
			{
				return this._idtypenetwork;
			}
			set
			{
				if ((this._idtypenetwork != value))
				{
					this._idtypenetwork = value;
				}
			}
		}



		public networkuserGetResult()
			{
			}

			public string cover
			{
				get
				{
					return this._cover;
				}
				set
				{
					if ((this._cover != value))
					{
						this._cover = value;
					}
				}
			}

			public string avatar
			{
				get
				{
					return this._avatar;
				}
				set
				{
					if ((this._avatar != value))
					{
						this._avatar = value;
					}
				}
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

			public System.Nullable<byte> idstate
			{
				get
				{
					return this._idstate;
				}
				set
				{
					if ((this._idstate != value))
					{
						this._idstate = value;
					}
				}
			}

			public System.Nullable<long> idnetworkBase
			{
				get
				{
					return this._idnetworkBase;
				}
				set
				{
					if ((this._idnetworkBase != value))
					{
						this._idnetworkBase = value;
					}
				}
			}

			public System.Nullable<byte> idtype
			{
				get
				{
					return this._idtype;
				}
				set
				{
					if ((this._idtype != value))
					{
						this._idtype = value;
					}
				}
			}

			public string nicname2
			{
				get
				{
					return this._nicname2;
				}
				set
				{
					if ((this._nicname2 != value))
					{
						this._nicname2 = value;
					}
				}
			}


			public System.Nullable<long> rank
			{
				get
				{
					return this._rank;
				}
				set
				{
					if ((this._rank != value))
					{
						this._rank = value;
					}
				}
			}
		}

	}
