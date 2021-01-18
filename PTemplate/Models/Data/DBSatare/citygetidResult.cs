﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Data.DBSatare
{
    public class citygetidResult
    {


			private int _id;

			private int _idprovince;

			private int _idcounty;

			private string _name;

			public citygetidResult()
			{
			}

		[Key]
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

			public int idprovince
			{
				get
				{
					return this._idprovince;
				}
				set
				{
					if ((this._idprovince != value))
					{
						this._idprovince = value;
					}
				}
			}

			public int idcounty
			{
				get
				{
					return this._idcounty;
				}
				set
				{
					if ((this._idcounty != value))
					{
						this._idcounty = value;
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
