using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classic
{
    class NotificationService // DIRECTOR
    {
        public Notification Construct(NotificationBuilder _builder)
        {
            _builder.AddIcon();
            _builder.AddMessage();
            _builder.AddPriority();
            _builder.AddSound();
            _builder.AddTitle();
            return _builder.Build();
        }
    }
}
