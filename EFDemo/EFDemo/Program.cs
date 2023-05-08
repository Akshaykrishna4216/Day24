using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using (var context = new Assignment2Entities())
            {
                var std = new CLIENT_MASTER()
                {
                    CLIENTNO = "C0006",
                    NAME = "Bill",
                    ADDRESS1 = "123 STREET",
                    ADDRESS2 = "123TRHJK",
                    CITY = "THRISSUR",
                    STATE = "KERALA",
                    BALDUE = 123456
                };
                context.CLIENT_MASTER.Add(std);

                context.SaveChanges();
            }

            using (var context = new Assignment2Entities())
            {
                var std = context.CLIENT_MASTER.First<CLIENT_MASTER>();
                std.NAME = "akhil";
                context.SaveChanges();
            }*/
            using (var context = new Assignment2Entities())
            {
                var std = context.CLIENT_MASTER.Where<S ==> S.NAME = "ANU">.FirstoDefault<CLIENT_MASTER>();
                
                context.CLIENT_MASTER.Remove(std);
                context.SaveChanges();

            }
        }
    }
}
