using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Center : Robot
    {
        public Center(string name, int height, int weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        public override int GetShotAccuracy()
        {
            if (shotType == "3 pointer")
            {
                return shotAccuracy = 2;
            }
            else if (shotType == "midrange")
            {
                return shotAccuracy = 4;
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
                Console.WriteLine("{0} attempts a 3 ball.", name);
            }
            else if (shotType == "midrange")
            {
                Console.WriteLine("{0} shoots the ball.", name);
            }
            else
            {
                Console.WriteLine("{0} monster dunk.", name);
            }

            ScorePoints();
        }

    }
}
