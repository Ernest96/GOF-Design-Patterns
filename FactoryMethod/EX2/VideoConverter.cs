using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    class VideoConverter : IConverter
    {
        public string Output { get; set; }

        public VideoConverter()
        {
            Output = "Default Path";
        }

        public void Convert()
        {
            Console.WriteLine("Converting video");
            // Do video Convert
        }
    }
}
