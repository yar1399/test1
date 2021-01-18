using Microsoft.EntityFrameworkCore;
using PTemplate.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics
{
   
    public static class StGet
    {
        private static ApplicationDbContext db = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
  
        public static StClassStruct GetStatestisc()
        {
       
            StClassStruct stClass = new StClassStruct();
            stClass.Today = (int)db.Statestics
                .Where(a => a.Day.Value.Year == DateTime.Now.Year)
                .Where(a => a.Day.Value.Month == DateTime.Now.Month)
                .Where(a => a.Day.Value.Day == DateTime.Now.Day)
                .Sum(a => a.Counter); 
           
            DateTime dt = DateTime.Now.AddDays(-1);
            try
            {
                stClass.Yesterday = (int)db.Statestics
                           .Where(a => a.Day.Value.Year == DateTime.Now.Year)
                           .Where(a => a.Day.Value.Month == DateTime.Now.Month)
                           .Where(a => a.Day.Value.Day == DateTime.Now.AddDays(-1).Day)
                           .Sum(a => a.Counter);
            }
            catch(Exception ex)
            {
                stClass.Yesterday = 0;
            }
            

            stClass.Month = (int)db.Statestics
                .Where(a => a.Day.Value.Year == DateTime.Now.Year )
                .Where(a => a.Day.Value.Month == DateTime.Now.Month).Sum(a=>a.Counter);
          
            
            stClass.LastMonth = (int)db.Statestics
                .Where(a => a.Day.Value.Year == DateTime.Now.Year)
                .Where(a => a.Day.Value.Month == (DateTime.Now.AddMonths(-1).Month)).Sum(a => a.Counter);

            stClass.Year =(int) db.Statestics.Where(a => a.Day.Value.Year == DateTime.Now.Year).Sum(a => a.Counter);
            stClass.Total = (int)db.Statestics.Sum(a => a.Counter);


            /**********************************************************/

            stClass.TodayIP = db.StatesticsDetils.Where(a => a.Date.Value.Year == DateTime.Now.Year)
                .Where(a => a.Date.Value.Month == DateTime.Now.Month)
                .Where(a => a.Date.Value.Day == DateTime.Now.Day)
                .Select(m => m.Ip).Distinct().Count();

            stClass.YesterdayIP = db.StatesticsDetils.Where(a => a.Date.Value.Year == DateTime.Now.Year)
                .Where(a => a.Date.Value.Month == DateTime.Now.Month)
                .Where(a => a.Date.Value.Day == DateTime.Now.AddDays(-1).Day)
                .Select(m => m.Ip).Distinct().Count();
           
            stClass.MonthIP = db.StatesticsDetils
                .Where(a => a.Date.Value.Year == DateTime.Now.Year)
                .Where(a => a.Date.Value.Month == DateTime.Now.Month)
                .Select(m => m.Ip).Distinct().Count();
            
            stClass.LastMonthIP = db.StatesticsDetils
                .Where(a => a.Date.Value.Year == DateTime.Now.Year)
                .Where(a => a.Date.Value.Month == (DateTime.Now.AddMonths(-1).Month ))
                .Select(m => m.Ip).Distinct().Count();
         
            stClass.YearIP = db.StatesticsDetils.Where(a => a.Date.Value.Year == DateTime.Now.Year)
                .Select(m => m.Ip).Distinct().Count();
           
            stClass.TotalIP = db.StatesticsDetils.Select(m => m.Ip).Distinct().Count();

            return stClass;

        }

    }
}
