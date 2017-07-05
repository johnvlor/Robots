using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Guard : Robot
    {
        public Guard(string name, int height, int weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;                
        }


        public override int GetShotAccuracy()
        {
            if (shotType == "3 pointer")
            {
                return shotAccuracy = 8;
            }
            else if (shotType == "midrange")
            {
                return shotAccuracy = 6;
            }
            else
            {
                return shotAccuracy = 2;
            }
        }

        public void DribblesBall()
        {
            Console.WriteLine("\n{0} dribbles the ball up the court.", name);
        }

        public override void ShootBall()
        {
            GetShotType();

            if (shotType == "3 pointer")
            {
                Console.WriteLine("{0} shoots a rainbow shot from downtown.", name);
            }
            else if (shotType == "midrange")
            {
                Console.WriteLine("{0} shoots the ball.", name);
            }
            else
            {
                Console.WriteLine("{0} attempts to dunk.", name);
            }
            
            ScorePoints();
        }



    }
}
