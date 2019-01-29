using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Fasade
{
    class ClientInfoFasade
    {
        public Person GetPersonByIdnp(string idnp)
        {
            Person p;

            p = PersonsCache.GetPersonByIdnp(idnp);
            if (p == null)
            {
                Console.WriteLine("Not found in CACHE, searching in DB");
                p = PersonsDb.GetPersonByIdnp(idnp);
                if (p != null)
                {
                    PersonsCache.InsertPerson(p);
                }
            }

            return p;
        }

        public List<Person> GetAllPersonsForced()
        {
            List<Person> persons;

            persons = PersonsDb.GetAllPersons();
            
            if (persons.Any())
            {
                foreach(var x in persons)
                {
                    PersonsCache.InsertPerson(x);
                }
            }

            return persons;
        }

        public void InsertPerson(Person p)
        {
            PersonsDb.InsertPerson(p);
            PersonsCache.InsertPerson(p);
        }

    }
}
