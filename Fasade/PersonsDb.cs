using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Fasade
{
    class PersonsDb
    {
        public static Person GetPersonByIdnp(string idnp)
        {
            Console.WriteLine($"Searching in DB idnp = {idnp}");

            var p = DbConnection.GetInstance.GetConnection().
                QueryFirstOrDefault<Person>($"SELECT * FROM person WHERE idnp = @_idnp", new { _idnp = idnp });
            return p;
        }

        public static List<Person> GetAllPersons()
        {
            Console.WriteLine($"Searching in DB all persons ");

            var persons = DbConnection.GetInstance.GetConnection().
                Query<Person>($"SELECT * FROM person;");
            return persons.ToList();
        }

        public static void InsertPerson(Person p)
        {
            Console.WriteLine($"Inserting person in DB idnp  = {p.idnp} ");
            DbConnection.GetInstance.GetConnection().
                Query("INSERT into person VALUES(@idnp, @firstname, @lastname, @address);", 
                new { idnp = p.idnp, firstname = p.firstname, lastname = p.lastname, address = p.address});
        }
    }
}
