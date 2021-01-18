using System;
using System.Collections.Generic;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Factor1
    {
        public Factor1()
        {
            Factorauthorities = new HashSet<Factorauthority>();
            Factorposts = new HashSet<Factorpost>();
            Factorsubs = new HashSet<Factorsub>();
        }

        public Guid Id { get; set; }
        public string Iduser { get; set; }
        public byte? Idfactorstate { get; set; }
        public int? Idbankstate { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Datecreate { get; set; }
        public DateTime? Datechangestate { get; set; }
        public long? Idproductaddress { get; set; }
        public string Authority { get; set; }
        public byte? Idproductpaytype { get; set; }
        public string Refid { get; set; }
        public byte? Idproductposttype { get; set; }

        public virtual Bankstate IdbankstateNavigation { get; set; }
        public virtual Factorstate IdfactorstateNavigation { get; set; }
        public virtual Productaddress IdproductaddressNavigation { get; set; }
        public virtual Productpaytype IdproductpaytypeNavigation { get; set; }
        public virtual Productposttype IdproductposttypeNavigation { get; set; }
        public virtual ICollection<Factorauthority> Factorauthorities { get; set; }
        public virtual ICollection<Factorpost> Factorposts { get; set; }
        public virtual ICollection<Factorsub> Factorsubs { get; set; }
    }
}
