using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class PowerForward : Robot
    {
        public PowerForward(string name, int height, int weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        public override int GetShotAccuracy()
        {
            if (shotType == "3 pointer")
            {
                return shotAccuracy = 6;
            }
            else if (shotType == "midrange")
            {
                return shotAccuracy = 5;
            }
            else
            {
                return shotAccuracy = 7;
            }
        }

        public override void ShootBall()
        {
            GetShotType();

            if (shotType == "3 pointer")
            {
                Console.WriteLine("{0} shoots a from deep.", name);
            }
            else if (shotType == "midrange")
            {
                Console.WriteLine("{0} shoots the ball.", name);
            }
            else
            {
                Console.WriteLine("{0} goes for a dunk.", name);
            }

            ScorePoints();
        }

    }
}
