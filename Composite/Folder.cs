using IPP.FlyWeight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Composite
{
    class Folder : DataComponent
    {
        private List<DataComponent> dataList = new List<DataComponent>();
        int filesCount;
        int foldersCount;

        public Folder()
        {
        }

        public Folder(string name, FlyWeightIcon icon)
        {
            this.name = name;
            this.icon = icon;
        }

        public override DataComponent Add(DataComponent component)
        {
            if (component is File)
                filesCount++;
            else if (component is Folder)
                foldersCount++;

            dataList.Add(component);
            return this;
        }

        public override DataComponent Remove(DataComponent component)
        {
            if (component is File)
                filesCount--;
            else if (component is Folder)
                foldersCount--;

            dataList.Remove(component);
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

            foreach (var x in dataList)
            {
                x.Display(depth + 1);
            }
        }

        public override void ShowData()
        {
            Console.WriteLine($"{name} contains: {foldersCount} folders, {filesCount} files");
        }
    }
}
