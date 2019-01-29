using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.FlyWeight
{
    class IconFactory
    {
        public enum IconType { FILE, FOLDER };
        private static Dictionary<IconType, FlyWeightIcon> icons = new Dictionary<IconType, FlyWeightIcon>();

        public static FlyWeightIcon GetIcon(IconType type)
        {
            FlyWeightIcon icon;

            if (icons.ContainsKey(type))
            {
                icons.TryGetValue(type, out icon);
            }
            else
            {
                switch (type)
                {
                    case IconType.FILE:
                        icon = new FileIcon();
                        break;
                    case IconType.FOLDER:
                        icon = new FolderIcon();
                        break;
                    default:
                        throw new Exception("Uknown icon type");
                }
                icons.Add(type, icon);
            }

            return icon;
        }
    }
}
