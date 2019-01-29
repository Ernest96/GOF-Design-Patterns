using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    abstract class Visitor
    {
        public abstract void VisitStudent(Person p);
        public abstract void VisitProfesor(Person p);
    }
}
