using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    class Cashier : Worker
    {
        public override void ProcessRequest(string p)
        {
            if (p.Contains("cash") || p.Contains("ring") || p.Contains("money") || p.Contains("customer"))

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
            return 400.00;
        }
    }
}
