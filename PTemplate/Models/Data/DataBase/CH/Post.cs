using System;
using System.Collections.Generic;
using System.Globalization;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Post
    {
        public Post()
        {
            Postdata = new HashSet<Postdatum>();
            Posttops = new HashSet<Posttop>();
        }

        public long Id { get; set; }
        public string Iduser { get; set; }
        public byte? Idposttype { get; set; }
        public byte? Idposttoptype { get; set; }
        public long? Idmenu { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Pathdata { get; set; }
        public DateTime? Datecreate { get; set; }
        public bool? Isactive { get; set; }
        public bool? Iswrite { get; set; }

        private DateTime? _Datestart;

        public DateTime? Datestart
        {
            get { return _Datestart; }
            set
            {
                if (value.Value.Year <= 1420)
                {
                    PersianCalendar persian = new PersianCalendar();
                DateTime DT;
                DateTime? date;
                try
                {
                    DT = (DateTime)value;
                    date = persian.ToDateTime(DT.Year, DT.Month, DT.Day, DT.Hour, DT.Minute, DT.Second, 0);

                }
                catch
                {
                    date = null;
                }



                _Datestart = date;
            }else
                {
                    _Datestart = value;
            }
        }
        }

        public virtual Menu IdmenuNavigation { get; set; }
        public virtual Posttoptype IdposttoptypeNavigation { get; set; }
        public virtual Posttype IdposttypeNavigation { get; set; }
        public virtual ICollection<Postdatum> Postdata { get; set; }
        public virtual ICollection<Posttop> Posttops { get; set; }
    }
}
