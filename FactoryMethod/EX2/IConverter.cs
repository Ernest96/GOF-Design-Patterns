﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    interface IConverter
    {
        string Output { get; set; }
        void Convert();
    }
}
