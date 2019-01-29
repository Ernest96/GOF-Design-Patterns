using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FlyWeight
{
    class FolderIcon : FlyWeightIcon
    {
        public FolderIcon()
        {
            imageData = "folder icon";
        }

        public override string GetCoordinates()
        {
            return $"x = {x}, y = {y}";
        }

        public override string GetImageData()
        {
            return imageData;
        }

        public override void SetCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
