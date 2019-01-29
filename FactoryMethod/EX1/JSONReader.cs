using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    public class JSONReader : Reader
    {
        public override string Read()
        {
            //read JSON;
            Console.WriteLine("Reading JSON");

            return "";
        }
    }
}
