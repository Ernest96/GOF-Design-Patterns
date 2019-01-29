using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Composite.Builder
{
    class FolderBuilder : DataComponentBuilder
    {
        private Folder folder = new Folder();

        public override DataComponentBuilder AddChild(DataComponent child)
        {
            folder.Add(child);
            return this;
        }

        public override DataComponentBuilder SetName(string name)
        {
            folder.name = name;
            return this;
        }

        public override DataComponentBuilder SetData(string data)
        {
            Console.WriteLine("Cannot set Data to a folder !");
            return this;
        }

        public override DataComponentBuilder SetExtension(string extension)
        {
            Console.WriteLine("Cannot set extension to a folder !");
            return this;
        }

        public override DataComponent Build()
        {
            if (String.IsNullOrWhiteSpace(folder.name))
            {
                throw new Exception("folder name not set !");
            }
            Folder tempFolder = folder;
            folder = new Folder();
            return tempFolder;
        }

    }
}
