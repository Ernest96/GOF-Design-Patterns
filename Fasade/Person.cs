using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Fasade
{
    class Person
    {
        public string idnp { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            string result;

            result = $"IDNP = {idnp}\n" +
                $"Firstname = {firstname}\n" +
                $"Lastname = {lastname}\n" +
                $"Address = {address}\n";

            return result;
        }
    }
}
