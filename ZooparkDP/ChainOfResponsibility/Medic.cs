using System;

namespace ZooparkDP
{
    class Medic : Worker
    {
        public override void ProcessRequest(string p)
        {
            if (p.Contains("medic"))

            {

                Console.WriteLine("{0} handles request {1}",

                  this.GetType().Name, p);

            }

            else if (successor != null)

            {

                successor.ProcessRequest(p);

            }

        }
    }
    }
