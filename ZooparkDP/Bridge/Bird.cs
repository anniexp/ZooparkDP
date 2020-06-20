using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{
    /// <summary>

    /// The 'ConcreteImplementor' class

    /// </summary>
    class Bird : ICage
    {
        public void CageType(string cage)
        {
            Console.WriteLine("Birds are in {0}", cage);
        }
    }
}
