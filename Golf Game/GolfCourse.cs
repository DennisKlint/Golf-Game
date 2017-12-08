using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Game
{
    class GolfCourse
    {
        Ball ball;
        Cup cup;

        private double courseSize;
        private double distanceTraveled;
        List<double> log = new List<double>();

        public GolfCourse()
        {
            //The amount of times we're allowing the player to swing at the ball
            var courseSwings = 7;
            courseSize = 0;
            ball = new Ball();
            courseSize = (ball.GetBallPosition() * 1.2);
            cup = new Cup();
            Console.WriteLine("Welcome to the Golf Game");
            Console.WriteLine("The ball is " + (ball.GetBallPosition() + cup.GetCupPosition()) + " meters away from the cup");
            Console.WriteLine("You have " + courseSwings + " swings to get to the cup");

            for (var i = 0; courseSwings > i; i++) {

//              log = new List<double>();

                SwingAtBall();
            //    log.Add(distanceTraveled);

            }
            Console.WriteLine("You're out of swings, game over!");
            Console.ReadKey();

        }

        private void SwingAtBall()
        {
            //distanceTraveled = ball.Swing();
            log.Add(ball.Swing());
            //If the ball goes outside the course
            if (ball.GetBallPosition() > courseSize)
            {
                throw new CustomException();
            }

            //If the ball passes the Cup, make sure it's position isn't negative
            if (ball.GetBallPosition() < 0)
            {
                Console.WriteLine("You missed by " + (ball.GetBallPosition() * -1));
                ball.ChangeBallPosition(ball.GetBallPosition() * -1);
            }

            //If ball position == Cup, you win!
            if (ball.GetBallPosition() == cup.GetCupPosition())
            {
                Console.WriteLine(Environment.NewLine + "You won!");
                Console.WriteLine("It took you " + log.Count + " swings to reach the cup");
                for (int i = 0; log.Count > i; i++) {
                    int swings = i + 1;
                    Console.WriteLine("On swing " + swings + " the ball traveled:" + log[i]);
                }
                Console.WriteLine(Environment.NewLine + "Thanks for playing!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("The ball is " + (ball.GetBallPosition() + cup.GetCupPosition()) + " meters away from the cup");
            Console.WriteLine("You've used " + log.Count + " swings so far");
            Console.ReadKey();
        }
    }
}
