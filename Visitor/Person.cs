using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    abstract class Person
    {
        public int money;
        public abstract void Accept(Visitor v);
    }
}
