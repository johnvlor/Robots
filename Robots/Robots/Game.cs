using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Game
    {
        int score;
        Guard robotGuard;
        PowerForward robotPowerForward;
        Center robotCenter;

        public Game()
        {
            robotGuard = new Guard("CurryBot", 75, 190);
            robotPowerForward = new PowerForward("GreekFreakBot", 73, 220);
            robotCenter = new Center("ShaqBot", 85, 325);
        }

        public void PlayGame()
        {
            RunPlays();

            robotGuard.DisplayPlayerStats();
            robotPowerForward.DisplayPlayerStats();
            robotCenter.DisplayPlayerStats();
        }

        public void RunPlays()
        {
            while (score < 10)
            {
                robotGuard.DribblesBall();

                string userInput;
                Console.WriteLine("(Pass or Shoot)");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "pass")
                {
                    robotGuard.PassBall();

                    int i = 0;
                    Random r = new Random();
                    i = r.Next(1, 3);

                    if (i == 1)
                    {
                        robotPowerForward.CatchBall();
                        robotPowerForward.ShootBall();
                    }
                    else if (i == 2)
                    {
                        robotCenter.CatchBall();
                        robotCenter.ShootBall();
                    }
                }
                else
                {
                    robotGuard.ShootBall();
                }
                score = (robotGuard.points + robotPowerForward.points + robotCenter.points);
                Console.WriteLine("Game Score: " + score);
            }
            Console.WriteLine("\nGood Game");
        }
    }


}
