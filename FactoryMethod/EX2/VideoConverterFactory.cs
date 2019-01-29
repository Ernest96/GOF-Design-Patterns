using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    class VideoConverterFactory : IFactory
    {
        public IConverter Create()
        {
            VideoConverter vc =  new VideoConverter();

            // actiuni suplimentare, grele

            return vc;
        }
    }
}
