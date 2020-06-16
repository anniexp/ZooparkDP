using System;

namespace ZooparkDP
{
    internal class Caretaker : Worker
    {
        public override void ProcessRequest(string p)
        {
            if (p.Contains("feed") ||p.Contains("clean"))

            {

                Console.WriteLine("{0} handles request {1}",

                  this.GetType().Name, p);

            }

            else

            {

                Console.WriteLine("No personal available!");

            }
            
        }
    }
    }
