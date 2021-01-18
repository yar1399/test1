using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
	public class networkGetResult
	{


		private long _id;

		private System.Nullable<byte> _idnetworktype;

		private string _iduser;

		private string _nickname;

		private System.Nullable<bool> _isactive;

		private System.Nullable<bool> _isactiveoprator;

		private System.Nullable<bool> _isdeletesystem;

		private System.Nullable<System.DateTime> _createnetworkdate;


		private System.Nullable<System.DateTime> _createdatedelete = DateTime.Now;

		public networkGetResult()
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

		//public System.Nullable<bool> isactiveoprator
		//{
		//	get
		//	{
		//		return this._isactiveoprator;
		//	}
		//	set
		//	{
		//		if ((this._isactiveoprator != value))
		//		{
		//			this._isactiveoprator = value;
		//		}
		//	}
		//}

		//public System.Nullable<bool> isdeletesystem
		//{
		//	get
		//	{
		//		return this._isdeletesystem;
		//	}
		//	set
		//	{
		//		if ((this._isdeletesystem != value))
		//		{
		//			this._isdeletesystem = value;
		//		}
		//	}
		//}

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

		//public System.Nullable<System.DateTime> createdatedelete
		//{
		//	get
		//	{
		//		return this._createdatedelete;
		//	}
		//	set
		//	{
		//		if ((this._createdatedelete != value))
		//		{
		//			this._createdatedelete = value;
		//		}
		//	}
		//}

	}
}