using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    public class XMLReader : Reader
    {
        public override string Read()
        {
            //read XML;
            Console.WriteLine("Reading XML");
            return "";
        }
    }
}
