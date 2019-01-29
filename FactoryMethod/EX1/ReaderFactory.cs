using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FactoryMethod
{
    public enum ReaderType { XML, JSON };

    public class ReaderFactory
    {
        private static Dictionary<ReaderType, Reader> Readers;

        static ReaderFactory()
        {
            Readers = new Dictionary<ReaderType, Reader>();

            Readers.Add(ReaderType.XML, new XMLReader());
            Readers.Add(ReaderType.JSON, new JSONReader());
        }

        public static Reader GetReader(ReaderType readerType)
        {
            Reader reader = null;
            Readers.TryGetValue(readerType, out reader);

            if (reader == null)
                throw new Exception("Invalid Reader Type");

            return reader;
        }
    }
}
