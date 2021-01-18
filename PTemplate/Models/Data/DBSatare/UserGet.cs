using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class UserGet
    {
		public UserGet()
		{

		}


		private long _id;

		private string _mobile;

		private string _email;

		private string _password;

		private System.Nullable<System.Guid> _token;

		private System.Nullable<byte> _Idactiveoperator;

		private System.Nullable<System.DateTime> _createuser;

		private System.Nullable<bool> _ahrazemail;

		private System.Nullable<bool> _ahrazregister;

		private System.Nullable<bool> _ahrazmobil;

		private System.Nullable<bool> _isdelete;

		private System.Nullable<bool> _isdeletesystem;

		private System.Nullable<bool> _isactive;

		private System.Nullable<bool> _isfactorenabled;

		

	
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

	
		public string mobile
		{
			get
			{
				return this._mobile;
			}
			set
			{
				if ((this._mobile != value))
				{
					this._mobile = value;
				}
			}
		}

	
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}

	
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}

		
		public System.Nullable<System.Guid> token
		{
			get
			{
				return this._token;
			}
			set
			{
				if ((this._token != value))
				{
					this._token = value;
				}
			}
		}

	
		public System.Nullable<byte> Idactiveoperator
		{
			get
			{
				return this._Idactiveoperator;
			}
			set
			{
				if ((this._Idactiveoperator != value))
				{
					this._Idactiveoperator = value;
				}
			}
		}

	
		public System.Nullable<System.DateTime> createuser
		{
			get
			{
				return this._createuser;
			}
			set
			{
				if ((this._createuser != value))
				{
					this._createuser = value;
				}
			}
		}

	
		public System.Nullable<bool> ahrazemail
		{
			get
			{
				return this._ahrazemail;
			}
			set
			{
				if ((this._ahrazemail != value))
				{
					this._ahrazemail = value;
				}
			}
		}

	
		public System.Nullable<bool> ahrazregister
		{
			get
			{
				return this._ahrazregister;
			}
			set
			{
				if ((this._ahrazregister != value))
				{
					this._ahrazregister = value;
				}
			}
		}

	
		public System.Nullable<bool> ahrazmobil
		{
			get
			{
				return this._ahrazmobil;
			}
			set
			{
				if ((this._ahrazmobil != value))
				{
					this._ahrazmobil = value;
				}
			}
		}

	
		public System.Nullable<bool> isdelete
		{
			get
			{
				return this._isdelete;
			}
			set
			{
				if ((this._isdelete != value))
				{
					this._isdelete = value;
				}
			}
		}

	
		public System.Nullable<bool> isdeletesystem
		{
			get
			{
				return this._isdeletesystem;
			}
			set
			{
				if ((this._isdeletesystem != value))
				{
					this._isdeletesystem = value;
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

		
		public System.Nullable<bool> isfactorenabled
		{
			get
			{
				return this._isfactorenabled;
			}
			set
			{
				if ((this._isfactorenabled != value))
				{
					this._isfactorenabled = value;
				}
			}
		}

	}
}
