using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    class Student : Person
    {
        public override void Accept(Visitor v)
        {
            v.VisitStudent(this);
        }
    }
}
