using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    class AudioConverterFactory : IFactory
    {
        public IConverter Create()
        {
            AudioConverter ac = new AudioConverter();

            // actiuni suplimentare, grele

            return ac;
        }
    }
}
