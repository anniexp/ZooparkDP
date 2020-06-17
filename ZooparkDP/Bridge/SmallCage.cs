using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{
    class SmallCage : Type
    {      
        public override void MakeType()
        {
            _ICage.CageType("a small cage");
        }
    }
}
