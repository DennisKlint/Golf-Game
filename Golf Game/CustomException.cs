using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Game
{
    class CustomException : Exception
    {
        public CustomException()
        {
            Console.WriteLine("You struck the ball out of the course!");
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
