using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Composite.Builder
{
    abstract class DataComponentBuilder
    {
        abstract public DataComponentBuilder SetExtension(string extension);
        abstract public DataComponentBuilder SetName(string name);
        abstract public DataComponentBuilder AddChild(DataComponent child);
        abstract public DataComponentBuilder SetData(string data);
        abstract public DataComponent Build();
    }
}
