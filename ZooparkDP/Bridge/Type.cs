using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{
    /// <summary>

    /// The 'Abstraction' class

    /// </summary>
    abstract class Type
    {
        // a reference to an object of type Implementor 
        public ICage _ICage;

        public abstract void MakeType();
       
    }
}
