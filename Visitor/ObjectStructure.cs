using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Visitor
{
    class ObjectStructure
    {
        private List<Person> list = new List<Person>();

        public void Attach(Person p)
        {
            list.Add(p);
        }

        public void Accept(Visitor v)
        {
            foreach(var x in list)
            {
                x.Accept(v);
            }
        }
    }
}
