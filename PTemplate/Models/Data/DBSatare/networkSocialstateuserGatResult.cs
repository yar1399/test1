using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkSocialstateuserGatResult
    {


			private string _iduser;

			private string _avatar;

			private System.Nullable<bool> _statebase;

			private System.Nullable<byte> _idstate;

			private System.Nullable<byte> _idtype;

			private string _name;

			private string _nickname;

			private System.Nullable<long> _idnetwork;

			private System.Nullable<bool> _blockuser;

			public networkSocialstateuserGatResult()
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

			public System.Nullable<bool> statebase
			{
				get
				{
					return this._statebase;
				}
				set
				{
					if ((this._statebase != value))
					{
						this._statebase = value;
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

			public System.Nullable<long> idnetwork
			{
				get
				{
					return this._idnetwork;
				}
				set
				{
					if ((this._idnetwork != value))
					{
						this._idnetwork = value;
					}
				}
			}

			public System.Nullable<bool> blockuser
			{
				get
				{
					return this._blockuser;
				}
				set
				{
					if ((this._blockuser != value))
					{
						this._blockuser = value;
					}
				}
			}
		}
	}
