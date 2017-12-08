using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Game
{
    
    class Ball
    {
        private int position;
        private const double GRAVITY = 9.8;

        public Ball()
        {
            Random rnd = new Random();
            position = rnd.Next(50, 300);
        }

        public double Swing ()
        {
            Console.Write("Please enter an angle:");
            var angle = Convert.ToDouble(Console.ReadLine());
            angle = ((Math.PI / 180) * angle);
            Console.Write(Environment.NewLine + "Please enter a velocity:");
            var velocity = Convert.ToDouble(Console.ReadLine());


            Func<double, double, double> calcSwingDistance = (x, y) => (Math.Pow(x, 2) / GRAVITY * Math.Sin(2 * y));
            
            var swingDistance = calcSwingDistance(velocity, angle);
            //Angle, Velocity

            position = (position - Convert.ToInt32(swingDistance));
            return swingDistance;
        }

        public int GetBallPosition()
        {
            return position;
        }
        public void ChangeBallPosition(int newPos)
        {
            position = newPos;
        }
    }
}
