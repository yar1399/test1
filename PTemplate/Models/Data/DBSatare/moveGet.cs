using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class moveGet
	{

			private int _id;

			private System.Nullable<bool> _isactive;

			private System.Nullable<bool> _isfree;

			private string _name;

			private string _namefa;

			private System.Nullable<float> _rating;

			public moveGet()
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

			public System.Nullable<bool> isfree
			{
				get
				{
					return this._isfree;
				}
				set
				{
					if ((this._isfree != value))
					{
						this._isfree = value;
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

			public string namefa
			{
				get
				{
					return this._namefa;
				}
				set
				{
					if ((this._namefa != value))
					{
						this._namefa = value;
					}
				}
			}

			public System.Nullable<float> rating
			{
				get
				{
					return this._rating;
				}
				set
				{
					if ((this._rating != value))
					{
						this._rating = value;
					}
				}
			}
		}
	}
