using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkSocialGetuserResult
    {
			private long _id;

			private string _iduser;

			private System.Nullable<int> _idnetworktype;

			private string _name;

			private string _nickname;

			private System.Nullable<bool> _isactive;

			private string _socialisActive;

			private string _chatisActive;

			private System.Nullable<int> _idstate;

			private System.Nullable<int> _idtype;

			private System.Nullable<bool> _blockuser;

			private System.Nullable<int> _counterpost;

			private System.Nullable<int> _followrs;

			private System.Nullable<int> _advocate;

			private System.Nullable<int> _following;

			private string _cover;

			private string _avatar;

	    	public string tell { get; set; }

	    	public long idshopping { get; set; }


		    private System.Nullable<System.DateTime> _createnetworkdate;

			public networkSocialGetuserResult()
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

			public System.Nullable<int> idnetworktype
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

			public System.Nullable<bool> isactive
			{
				get
				{
					return this._isactive;
				}
				set
				{
					if ((this._isactive != value))
					{
						this._isactive = value;
					}
				}
			}

			public string socialisActive
			{
				get
				{
					return this._socialisActive;
				}
				set
				{
					if ((this._socialisActive != value))
					{
						this._socialisActive = value;
					}
				}
			}

			public string chatisActive
			{
				get
				{
					return this._chatisActive;
				}
				set
				{
					if ((this._chatisActive != value))
					{
						this._chatisActive = value;
					}
				}
			}

			public System.Nullable<int> idstate
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

			public System.Nullable<int> idtype
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

			public System.Nullable<int> counterpost
			{
				get
				{
					return this._counterpost;
				}
				set
				{
					if ((this._counterpost != value))
					{
						this._counterpost = value;
					}
				}
			}

			public System.Nullable<int> followrs
			{
				get
				{
					return this._followrs;
				}
				set
				{
					if ((this._followrs != value))
					{
						this._followrs = value;
					}
				}
			}

			public System.Nullable<int> advocate
			{
				get
				{
					return this._advocate;
				}
				set
				{
					if ((this._advocate != value))
					{
						this._advocate = value;
					}
				}
			}

			public System.Nullable<int> following
			{
				get
				{
					return this._following;
				}
				set
				{
					if ((this._following != value))
					{
						this._following = value;
					}
				}
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

			public System.Nullable<System.DateTime> createnetworkdate
			{
				get
				{
					return this._createnetworkdate;
				}
				set
				{
					if ((this._createnetworkdate != value))
					{
						this._createnetworkdate = value;
					}
				}
			}
		}
	}
