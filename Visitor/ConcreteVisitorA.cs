using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    class ConcreteVisitorA : Visitor
    {

        public override void VisitStudent(Person p)
        {
            p.money += 600; // dolari
            Console.WriteLine("p.money += 600");
        }

        public override void VisitProfesor(Person p)
        {
            p.money += 4000; // dolari
            Console.WriteLine("p.money += 4000");

        }
    }
}
