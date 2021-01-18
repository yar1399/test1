using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkpostGetUserResult
    {


			private long _id;

			private System.Nullable<byte> _idposttype;

			private string _description;

			private string _path;

			private System.Nullable<System.DateTime> _datecreate;

			private System.Nullable<long> _idnetwork;

			private string _iduser;

			private string _pathvatar;

			private string _nickname;

			public networkpostGetUserResult()
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

			public System.Nullable<byte> idposttype
			{
				get
				{
					return this._idposttype;
				}
				set
				{
					if ((this._idposttype != value))
					{
						this._idposttype = value;
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

			public string path
			{
				get
				{
					return this._path;
				}
				set
				{
					if ((this._path != value))
					{
						this._path = value;
					}
				}
			}

			public System.Nullable<System.DateTime> datecreate
			{
				get
				{
					return this._datecreate;
				}
				set
				{
					if ((this._datecreate != value))
					{
						this._datecreate = value;
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

			public string pathvatar
			{
				get
				{
					return this._pathvatar;
				}
				set
				{
					if ((this._pathvatar != value))
					{
						this._pathvatar = value;
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
