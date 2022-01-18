using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Billiard_Rules 
    {

        public string[] balls = new string[20];
        Ball_detaction ball = new Ball_detaction();
        int[] balltype = new int[2];
        void Scoreboard()
        {
            balls = ball.balls;
            if(NumberOfBallsOfEachtype(balls)[0]==1)
            {


            }


        }
        int[] NumberOfBallsOfEachtype(String[] ball)
        {
            int solidColorBall =0;
            int halfColorBall =0;

            for (int i = 0; i < ball.GetUpperBound(0); i++)
            {
                if(ball[i] == "orange-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "green-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "red-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "blue-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "purple-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "yellow-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "brown-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "orange-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "green-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "red-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "blue-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "purple-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "yellow-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "brown-half")
                {
                    halfColorBall++;
                }
            }
            balltype[0] = halfColorBall;
            balltype[1] = solidColorBall;
            return balltype;
        }
    }
}
