using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Fasade
{
    class PersonsCache
    {
        public static volatile ConcurrentDictionary<string, Person> cache = 
            new ConcurrentDictionary<string, Person>();

        public static Person GetPersonByIdnp(string idnp)
        {
            Console.WriteLine($"Searching in CACHE idnp = {idnp}");
            Person p = new Person();

            cache.TryGetValue(idnp, out p);
            return p;
        }


        public static void InsertPerson(Person p)
        {
            Console.WriteLine($"Inserting person in CACHE idnp  = {p.idnp} ");

            if (!cache.ContainsKey(p.idnp))
            {
                cache.TryAdd(p.idnp, p);
            }
        }
    }
}
