﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP.Bridge
{

    /// <summary>

    /// The 'RefinedAbstraction' class

    /// </summary>
    class BigCage : Type
    {
        public override void MakeType()
        {
            _ICage.CageType(" a big cage");
        }
    }
}
