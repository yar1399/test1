using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class valuebodyGetResult
    {


			private System.Nullable<byte> _idvalue;

			private System.Nullable<long> _idclient;

			private System.Nullable<decimal> _value;

			private System.DateTime _date;

			private System.Nullable<long> _iduser;

			private int _type;

			public valuebodyGetResult()
			{
			}

			public System.Nullable<byte> idvalue
			{
				get
				{
					return this._idvalue;
				}
				set
				{
					if ((this._idvalue != value))
					{
						this._idvalue = value;
					}
				}
			}

			public System.Nullable<long> idclient
			{
				get
				{
					return this._idclient;
				}
				set
				{
					if ((this._idclient != value))
					{
						this._idclient = value;
					}
				}
			}

			public System.Nullable<decimal> value
			{
				get
				{
					return this._value;
				}
				set
				{
					if ((this._value != value))
					{
						this._value = value;
					}
				}
			}

			public System.DateTime date
			{
				get
				{
					return this._date;
				}
				set
				{
					if ((this._date != value))
					{
						this._date = value;
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

			public int type
			{
				get
				{
					return this._type;
				}
				set
				{
					if ((this._type != value))
					{
						this._type = value;
					}
				}
			}
		}
	}
