using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
	[Keyless]
	public class movesportGetResult
	{


		private System.Nullable<int> _idmove;

		private string _name;

		private string _namefa;

		private System.Nullable<bool> _isfree;

		private System.Nullable<byte> _idsport;

		private string _namesport;

		private string _image;

		private System.Nullable<float> _rating;

		private System.Nullable<int> _idmusle;

		public movesportGetResult()
		{
		}


		public System.Nullable<int> idmove
		{
			get
			{
				return this._idmove;
			}
			set
			{
				if ((this._idmove != value))
				{
					this._idmove = value;
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

		public System.Nullable<byte> idsport
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

		public string namesport
		{
			get
			{
				return this._namesport;
			}
			set
			{
				if ((this._namesport != value))
				{
					this._namesport = value;
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
	}

}
