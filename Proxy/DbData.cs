using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPP.Proxy
{
    //Real Subject
    class DbData : IData
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();

        public string ReadData(string key)
        {
            Console.WriteLine("Reading from DB... ");
            Thread.Sleep(3000);

            string result;
            data.TryGetValue(key, out result);

            if (result == null)
                result = "No data found for key = " + key;

            return result;
        }

        public void WriteData(string key, string value)
        {
            Console.WriteLine("Writing to DB... ");
            data.Add(key, value);
            Thread.Sleep(3000);
            Console.WriteLine("Data writen to DB \n");
        }
    }
}
