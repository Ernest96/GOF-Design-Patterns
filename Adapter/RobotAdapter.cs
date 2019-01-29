using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Adapter
{
    //Adapter
    public class RobotAdapter : IEnemyDestroyer
    {
        Robot theRobot;

        public RobotAdapter(Robot newRobot)
        {
            theRobot = newRobot;
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }

        public void driveForward()
        {
            theRobot.flyForward();
        }

    }
}
