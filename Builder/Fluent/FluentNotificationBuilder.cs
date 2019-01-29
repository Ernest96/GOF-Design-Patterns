using Builder;
using Builder.Classic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Builder.Fluent
{
    class FluentNotificationBuilder
    {
        private Notification notification;

        public FluentNotificationBuilder()
        {
            this.notification = new Notification();
        }

        public FluentNotificationBuilder AddTitle(string title)
        {
            notification.title = title;
            return this;
        }

        public FluentNotificationBuilder AddMessage(string message)
        {
            notification.message = message;
            return this;
        }

        public FluentNotificationBuilder AddIcon(NotificationIcon icon)
        {
            notification.icon = icon;
            return this;
        }

        public FluentNotificationBuilder AddSound(NotificationSound sound)
        {
            notification.sound = sound;
            return this;
        }

        public FluentNotificationBuilder AddPriority(int priority)
        {
            notification.priority = priority;
            return this;
        }

        public Notification Build()
        {
            notification.id = "iOS:" + 1231;
            return notification;
        }
    }
}
