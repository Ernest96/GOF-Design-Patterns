using Builder.Classic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Notification // product
    {
        public string id { get; set; }
        public string message { get; set; }
        public string title { get; set; }
        public NotificationIcon icon { get; set; }
        public NotificationSound sound { get; set; }
        public int priority { get; set; }
        public string type { get; set; }
        public string server { get; set; }

        public Notification()
        {
            icon = new NotificationIcon();
            sound = new NotificationSound();
        }

        public override string ToString()
        {
            return $"Title = {title}\n" +
                   $"Message = {message}\n" +
                   $"Priority =  {priority}\n" +
                   $"Sound = {sound.ToString()}\n" +
                   $"Icon = {icon.ToString()}\n" +
                   $"Type = {type}\n" +
                   $"id = {id}\n" +
                   $"Notifications server = {server}\n";
        }
    }
}
