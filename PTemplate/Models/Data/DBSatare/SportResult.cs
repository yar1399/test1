using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class SportResult
    {


			private byte _id;

			private string _name;

			private string _image;

			private string _description;

			private System.Nullable<bool> _isactive;

			public SportResult()
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

			public string image
			{
				get
				{
					return this._image;
				}
				set
				{
					if ((this._image != value))
					{
						this._image = value;
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
