using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Robot
    {
        public string name;
        public int points;
        public string shotType;
        public int shotAccuracy;
        public int height;
        public int weight;

        public Robot()
        {

        }

        public virtual void ShootBall()
        {
            Console.WriteLine("{0} shoots the ball.", name);
            GetShotType();
            ScorePoints();
        }

        public void PassBall()
        {
            Console.WriteLine("\n{0} passes the ball.", name);
        }

        public void CatchBall()
        {
            Console.WriteLine("{0} catches the ball.", name);
        }

        public virtual int GetShotAccuracy()
        {
            if (shotType == "3 pointer")
            {
                return shotAccuracy = 5;
            }
            else if (shotType == "midrange")
            {
                return shotAccuracy = 5;
            }
            else
            {
                return shotAccuracy = 5;
            }
        }

        public int GetPoints()
        {
            if (shotType == "3 pointer")
            {
                return points += 3;
            }
            else
            {
                return points += 2;
            }
        }

        public void DisplayPlayerStats()
        {
            Console.WriteLine("\nStat Line:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Points: {0}", points);
        }

        public void ScorePoints()
        {
            GetShotAccuracy();

            int takeShot = 0;
            Random r = new Random();
            takeShot = r.Next(shotAccuracy, 11);

            if (takeShot >= 8)
            {
                Console.WriteLine("{0} scores.", name);
                GetPoints();
            }
            else
            {
                Console.WriteLine("{0} misses the shot.", name);                
            }
        }

        public void GetShotType()
        {
            int distance = 0;
            Random r = new Random();
            distance = r.Next(1, 10);

            if (distance >= 7)
            {
                shotType = "3 pointer";
            }
            else if ((distance < 7) && (distance > 3))
            {
                shotType = "midrange";
            }
            else if (distance <= 3)
            {
                shotType = "dunk";
            }

            Console.WriteLine("\nShot: " + shotType);
        }

        
    }
}
