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
        bool gameStart;
        Player player1 = new Player();
        Player player2 = new Player();
        static Random rand = new Random();
        bool balltypesChosen;
        int b = rand.Next(0, 1);
        bool gameOpend = true;
        bool firstplay;
        bool c;
        void BallTypeSelection(Player p, bool gameStart)
        {
            balls = ball.TestIteration();
            if (gameOpend == true)
            {
                gameOpend = false;
                if ((NumberOfBallsOfEachtype(balls)[0] < 7 || NumberOfBallsOfEachtype(balls)[1] < 7))
                {
                    firstplay = true;
                    c = true;
                    balls = ball.TestIteration();
                    Thread.Sleep(16000);
                    if (NumberOfBallsOfEachtype(balls)[0] < 6 && NumberOfBallsOfEachtype(balls)[1] == 7)
                    {
                        p.halfball = true;
                        gameStart = false;
                        balltypesChosen = true;
                    }
                    if (NumberOfBallsOfEachtype(balls)[0] == 7 && NumberOfBallsOfEachtype(balls)[1] < 6)
                    {
                        gameStart = false;
                        p.solidball = true;
                        balltypesChosen = true;
                    }
                    if (NumberOfBallsOfEachtype(balls)[0] <= 5 && NumberOfBallsOfEachtype(balls)[1] <= 6)
                    {
                        gameStart = false;
                        p.halfball = true;
                        balltypesChosen = true;
                    }
                    if (NumberOfBallsOfEachtype(balls)[0] <= 6 && NumberOfBallsOfEachtype(balls)[1] <= 5)
                    {
                        gameStart = false;
                        p.solidball = true;
                        balltypesChosen = true;
                    }
                }
            }
            if(gameOpend == false || firstplay == false)
            {
                if (NumberOfBallsOfEachtype(balls)[0] <= 6 && NumberOfBallsOfEachtype(balls)[1] == 7 && c == false)
                {
                    p.halfball = true;
                    gameStart = false;
                    balltypesChosen = true;
                }
                if (NumberOfBallsOfEachtype(balls)[0] == 7 && NumberOfBallsOfEachtype(balls)[1] <= 6 && c == false)
                {
                    p.solidball = true;
                    gameStart = false;
                    balltypesChosen = true;
                }
                if (NumberOfBallsOfEachtype(balls)[0] <=5  && NumberOfBallsOfEachtype(balls)[1] <= 7)
                {
                    p.halfball = true;
                    gameStart = false;
                    balltypesChosen = true;
                }
                if (NumberOfBallsOfEachtype(balls)[0] <= 5 && NumberOfBallsOfEachtype(balls)[1] <= 7)
                {
                    p.halfball = true;
                    gameStart = false;
                    balltypesChosen = true;
                }
            }
            firstplay = false;
        }
        void PlayerTurn(bool gameStart)
        {
            if (gameStart == true)
            {

                if (b == 0 && gameStart == true)
                {
                    player1.playerTurn = true;
                    BallTypeSelection(player1,gameStart);
                    b = 1;
                }
                else if (b == 1 && gameStart == true)
                {
                    player2.playerTurn = true;
                    BallTypeSelection(player2,gameStart);
                    b = 0;
                }
            }
        }
        void Scoreboard()
        {
          
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
                if(ball[i] == "orange-half")
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
                if (ball[i] == "blue-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "purple-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "red-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "green-half")
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
