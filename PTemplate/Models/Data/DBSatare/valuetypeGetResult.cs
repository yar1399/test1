using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class valuetypeGetResult
    {


			private byte _id;

			private string _name;

			private string _description;

			private string _path;

			private System.Nullable<bool> _isactive;

			public valuetypeGetResult()
			{
			}

			public byte id
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
		}
	}
