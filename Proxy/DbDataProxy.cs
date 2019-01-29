using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPP.Proxy
{
    //Proxy
    class DbDataProxy : IData
    {
        private Dictionary<string, string> data = new Dictionary<string,string>();
        private DbData dbData = new DbData();

        public string ReadData(string key)
        {
            Console.WriteLine("Reading from cache... ");
            Thread.Sleep(500);

            string result;
            data.TryGetValue(key, out result);

            if (result == null)
            {
                Console.WriteLine("No data found in cache for key = " + key);
                Console.WriteLine("Searching data in DB...\n");
                result = dbData.ReadData(key);
            }

            return result;
        }

        public void WriteData(string key, string value)
        {
            Console.WriteLine("Writing to cache... ");
            data.Add(key, value);
            Thread.Sleep(500);
            Console.WriteLine("Data writenn to cache, adding to DB ");
            dbData.WriteData(key, value);
        }
    }
}
