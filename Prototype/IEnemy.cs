using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Prototype
{
    interface IEnemy
    {
        //int id { get; set; }
        int damage { get; set; }
        int life { get; set; }
        string color { get; set; }
        string weapon { get; set; }

        int Attack();
        IEnemy Clone();
    }
}
