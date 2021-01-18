
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTemplate.Models.Statestics
{
    public static class stOnlion
    {
        public static List<On> users = new List<On>();

        public static bool Set(On on)
        {
            try {
                RemoveExperied();
                users.Add(on);
                return true;
            } catch {
                return false;
            }
        }


        public static int GetOnlion()
        {
            var getUser = users.Where(a => a.Time >= DateTime.Now).ToList();

            RemoveExperied();
            return getUser.Count;
        }

        private static bool RemoveExperied()
        {
           
            try 
            {
                users.RemoveAll(a => a.Time <= DateTime.Now);
                return true;
            } 
            catch 
            {
                return false;
            }
        }

        internal static bool Update(string key)
        {
            try
            {
                var q = users.Where(a => a.Key == key).First();
                users.Remove(q);
                q.Time = DateTime.Now.AddMinutes(20);
                users.Add(q);
                return true;
            }
            catch
            {
                return false;
            }
        
        }
    }
}
