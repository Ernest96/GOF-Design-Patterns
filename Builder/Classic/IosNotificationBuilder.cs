using Builder.Classic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classic
{
    class IosNotificationBuilder : NotificationBuilder // Concrete Builder
    {
        public override void AddTitle()
        {
            notification.title = "iOS notification title";
        }

        public override void AddMessage()
        {
            notification.message = "Notification text";
        }

        public override void AddIcon()
        {
            notification.icon = new NotificationIcon();
        }

        public override void AddSound()
        {
            notification.sound = new NotificationSound();
        }

        public override void AddPriority()
        {
            notification.priority = 2;
        }

        public override Notification Build()
        {
            Random random = new Random();
            int id = random.Next(0, 4000);

            notification.id = "iOS:" + id;
            notification.type = "iOS";
            notification.server = "apple.push.com";
            return notification;
        }
        
    }
}
