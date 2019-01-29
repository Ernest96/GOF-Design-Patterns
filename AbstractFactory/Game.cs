using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class Game
    {
        private static volatile Game instance;
        private static volatile object createLock = new object();
        public Level level { get; private set; }
        public int levelsCounter { get; private set; }
        
        public static Game getInstance()
        {
            if (instance == null)
            {
                lock (createLock)
                {
                    if (instance == null)
                    {
                        instance = new Game();
                    }
                }
            }
            return instance;
        }

        public void SetLevel(Level level)
        {
            instance.level = level;
            instance.levelsCounter++;
        }
        
    }
}
