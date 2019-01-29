using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Composite.Builder
{
    class FileBuilder : DataComponentBuilder
    {
        private File file = new File();

        public override DataComponentBuilder SetExtension(string extension)
        {
            file.extension = extension;
            return this;
        }

        public override DataComponentBuilder SetName(string name)
        {
            file.name = name;
            return this;
        }

        public override DataComponentBuilder SetData(string data)
        {
            file.data = data;
            file.size = data.Length;
            return this;
        }

        public override DataComponentBuilder AddChild(DataComponent dataComponent)
        {
            Console.WriteLine("Cannot add child to a file");
            return this;
        }

        public override DataComponent Build()
        {
            if (String.IsNullOrWhiteSpace(file.name))
            {
                throw new Exception("file name not set !");
            }
            File tempFile = file;
            file = new File();
            return tempFile;
        }
    }
}
