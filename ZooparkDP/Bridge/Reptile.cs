using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{
    class Reptile : ICage
    {
        public void CageType(string cage)
        {
            Console.WriteLine("Reptiles are in {0}", cage);
        }
    }
}
