using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPP.FlyWeight;


namespace IPP.Composite
{
    class File : DataComponent
    {
        public File()
        {
        }

        public File(string name, FlyWeightIcon icon)
        {
            this.name = name;
            this.icon = icon;
        }

        public override DataComponent Add(DataComponent component)
        {
            Console.WriteLine("Can't add file in a file.");
            return this;
        }

        public override DataComponent Remove(DataComponent component)
        {
            Console.WriteLine("Can't remove file from a file.");
            return this;
        }

        public override void Display(int depth = 0)
        {
            for (int i = 0; i < depth; ++i)
            {
                if (i == depth - 1)
                    Console.Write("└ ");
                else
                    Console.Write(" ");
            }

            Console.WriteLine($"{name} ({icon.GetImageData()}) {icon.GetCoordinates()}");
            
        }

        public override void ShowData()
        {
            Console.WriteLine($"File {name} data : {data}");
            Console.WriteLine($"size: ({size} bytes)");
        }
    }
}
