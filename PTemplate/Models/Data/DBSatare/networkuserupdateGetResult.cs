using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class networkuserupdateGetResult
    {
	

			private System.Nullable<System.DateTime> _datecreate;

			private string _iduser;

			private System.Nullable<byte> _idstate;

			public networkuserupdateGetResult()
			{
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

		[Key]
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

			public System.Nullable<byte> idstate
			{
				get
				{
					return this._idstate;
				}
				set
				{
					if ((this._idstate != value))
					{
						this._idstate = value;
					}
				}
			}
		}
	}
