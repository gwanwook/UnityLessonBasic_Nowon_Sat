using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_HorseRacingGame
{
    internal class Horse
    {
        public HorseStats horseStats;

        public void setHorseStats(string name, int speed, int runLength)
        {
            horseStats.name = name;
            horseStats.horseSpeed = speed;
            horseStats.runLength = runLength;
        }

        public int run()
        {
            return horseStats.runLength += horseStats.horseSpeed;
        }
    }
}
