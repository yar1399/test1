using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class UserRolesGetResult
    {


			private byte _id;

			private string _name;

			private string _description;

			private System.Nullable<long> _iduser;

			public UserRolesGetResult()
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

			public System.Nullable<long> iduser
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
		}
	}
