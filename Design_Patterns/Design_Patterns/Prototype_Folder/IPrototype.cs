﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype_Folder
{
    internal interface IPrototype
    {
        IPrototype Clone();
    }
}
