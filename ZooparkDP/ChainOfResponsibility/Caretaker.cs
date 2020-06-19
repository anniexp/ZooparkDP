﻿using System;

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
            return 600.00;
        }
    }
    }
