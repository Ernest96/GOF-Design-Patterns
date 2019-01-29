using Builder.Classic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classic
{
    abstract class NotificationBuilder // Builder abstract
    {
        protected Notification notification = new Notification();

        public abstract void AddPriority();
        public abstract void AddTitle();
        public abstract void AddMessage();
        public abstract void AddIcon();
        public abstract void AddSound();
        public abstract Notification Build();
    }
}
