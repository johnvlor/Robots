﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Game basketbotGame = new Game();
            basketbotGame.PlayGame();

            Console.ReadKey();
        }
    }
}
