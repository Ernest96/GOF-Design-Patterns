using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    class Profesor : Person
    {
        public override void Accept(Visitor v)
        {
            v.VisitProfesor(this);
        }
    }
}
