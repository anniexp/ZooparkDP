using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{
    class Mammal : ICage
    {
        public void CageType(string cage)
        {
            Console.WriteLine("Mammals are in {0}", cage);
        }
    }
}
