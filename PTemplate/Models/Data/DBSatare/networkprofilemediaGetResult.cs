using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkprofilemediaGetResult
    {


			private long _id;

			private string _path;

			private System.Nullable<byte> _idtype;

			private string _description;

			private System.Nullable<long> _idnetwork;

			private System.Nullable<System.DateTime> _datecreate;

			public networkprofilemediaGetResult()
			{
			}

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
		}

	}
