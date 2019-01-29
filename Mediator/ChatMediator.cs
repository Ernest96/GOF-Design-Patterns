using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Mediator
{
    class ChatMediator : Mediator
    {
        public User1 user1;
        public User2 user2;

        public override void Send(string message, AbstractUser user)
        {
            if (user == user1)
            {
                user2.Notify(message);
            }
            else if(user == user2)
            {
                user1.Notify(message);
            }
        }


    }
}
