using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    class AudioConverter : IConverter
    {
        public string Output { get; set; }

        public AudioConverter()
        {
            Output = "Default Path";
        }

        public void Convert()
        {
            Console.WriteLine("Converting audio");
            // Do video Convert
        }
    }
}
