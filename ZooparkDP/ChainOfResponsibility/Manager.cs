using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    class Manager : Worker
    {
        public override void ProcessRequest(string p)
        {

            if (p.Contains("manage"))

            {
                Console.WriteLine("{0} handles request {1}",

                  this.GetType().Name, p);
            }

            else if (successor != null)

            {
                successor.ProcessRequest(p);
            }
            else

            {

                Console.WriteLine("No personal available!");

            }
        }
        public static double SalaryPerWeek()
        {
            return 900.00;
        }
    }
}
