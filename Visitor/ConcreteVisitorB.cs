using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    class ConcreteVisitorB : Visitor
    {
        public override void VisitStudent(Person p)
        {
            p.money -= 300; // cheltuieli
            Console.WriteLine("p.money -= 300");
        }

        public override void VisitProfesor(Person p)
        {
            p.money -= 3000; // cheltuieli
            Console.WriteLine("p.money -= 3000");

        }
    }
}
