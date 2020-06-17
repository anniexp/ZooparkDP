using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{
    class SmallCage : Type
    {     
        //creates a type of cage, implementing ICage interface
        public override void MakeType()
        {
            //variable of typeICage
            _ICage.CageType("a small cage");
        }
    }
}
