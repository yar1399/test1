using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class sportmusle
    {
	

			private int _id;

			private System.Nullable<int> _idmusle;

			private System.Nullable<int> _idsport;

			private string _image;

			private System.Nullable<bool> _isactive;

			private string _name;

			public sportmusle()
			{
			}

			
			public int id
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

			
			public System.Nullable<int> idmusle
			{
				get
				{
					return this._idmusle;
				}
				set
				{
					if ((this._idmusle != value))
					{
						this._idmusle = value;
					}
				}
			}

			
			public System.Nullable<int> idsport
			{
				get
				{
					return this._idsport;
				}
				set
				{
					if ((this._idsport != value))
					{
						this._idsport = value;
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
		}
	}
