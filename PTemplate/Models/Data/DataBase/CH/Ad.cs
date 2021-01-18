using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

#nullable disable

namespace PTemplate.Data.DataBase
{
    public partial class Ad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Path { get; set; }
        public string Link { get; set; }
        public bool? Isactive { get; set; }
        private DateTime? _Datecreate { get; set; }
        private DateTime? _Datestart { get; set; }
        private DateTime? _Dateend { get; set; }

        public DateTime? Datecreate
        {
            get { return _Datecreate; }
            set
            {
                if(value.Value.Year<=1420)
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

                _Datecreate = date;
                }else
                {
                    _Datecreate = value;
                }
            }
        }
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
                }
                else
                {
                    _Datestart = value;
                }
            }
        }
        public DateTime? Dateend
        {
            get { return _Dateend; }
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



                _Dateend = date;
                }
                else
                {
                    _Dateend = value;
                }
            }
        }

    }
}
