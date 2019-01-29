using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Proxy
{
    //Subject
    interface IData
    {
        string ReadData(string key);
        void WriteData(string key, string value);
    }
}
