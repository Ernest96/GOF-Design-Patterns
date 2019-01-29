using Builder.Classic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classic
{
    class AndroidNotificationBuilder : NotificationBuilder
    {
        public override void AddTitle()
        {
            notification.title = "Android notification title";
        }

        public override void AddMessage()
        {
            notification.message = "Notification text";
        }

        public override void AddIcon()
        {
            notification.icon = new NotificationIcon();
            if (notification.priority > 1)
                notification.icon.iconName = "importantIcon.png";
        }

        public override void AddSound()
        {
            notification.sound = new NotificationSound();
        }

        public override void AddPriority()
        {
            notification.priority = 1;
            //prioritate
        }

        public override Notification Build()
        {
            Random random = new Random();
            int id = random.Next(0, 2000);
            
            notification.id = "Android:" + id;
            notification.type = "Android";
            notification.server = "google.notifications.com";
            return notification;
        }
    }
}
