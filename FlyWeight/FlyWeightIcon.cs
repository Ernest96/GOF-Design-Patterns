using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FlyWeight
{
    abstract class FlyWeightIcon
    {
        //intrinsec attribute
        protected string imageData;

        //extrinsec attributes
        public int x;
        public int y;

        abstract public string GetImageData();
        abstract public string GetCoordinates();
        abstract public void SetCoordinates(int x, int y);
    }
}
