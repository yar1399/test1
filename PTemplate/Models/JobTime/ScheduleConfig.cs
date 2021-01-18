using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.JobTime
{
    public class ScheduleConfig<T> : IScheduleConfig<T>
    {
        public string CronExpression { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
    }
}
