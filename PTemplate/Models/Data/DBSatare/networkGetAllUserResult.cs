using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkGetAllUserResult
    {


			private long _id;

			private System.Nullable<byte> _idnetworktype;

			private string _iduser;

			private string _nickname;

			private System.Nullable<bool> _isactive;

			private System.Nullable<System.DateTime> _createnetworkdate;

			public networkGetAllUserResult()
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
