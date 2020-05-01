using System;
using System.Collections.Generic;

/* Given a list of strings, each string can be one of the 4 following types:
 Integer (one round's score): Directly represents the number of points you get in this round.
"+" (one round's score): Represents that the points you get in this round are the sum of the last two valid round's points.
 "D" (one round's score): Represents that the points you get in this round are the doubled data of the last valid round's points.
 "C" (an operation, which isn't a round's score): Represents the last valid round's points you get were invalid and should be removed. */

namespace project
{
    public class GameScore
    {
        public static int CalculateScores(string[] ops)
        {
            Stack<int> scoreStack = new Stack<int>();
            int scoreSum = 0;

            foreach (var score in ops)
            {
                int roundScore;
                bool isScore = Int32.TryParse(score, out roundScore);

                if( isScore )
                {
                    scoreStack.Push(roundScore);
                }
                else
                {
                    switch(score)
                    {
                        case "+" :
                        //points you get in this round are the sum of the last two valid round's points
                        var top = scoreStack.Pop();
                        var newTop = top + scoreStack.Peek();
                        scoreStack.Push(top);
                        scoreStack.Push(newTop);
                        break;

                        case "D" :
                        // points you get in this round are the doubled data of the last valid round's points.
                        scoreStack.Push(scoreStack.Peek() * 2);
                        break;

                        case "C" :
                        // last valid round's points you get were invalid and should be removed.
                        scoreStack.Pop();
                        break;

                    }
                }               
            }

            foreach (var score in scoreStack)
            {
                scoreSum += score;
            }

            return scoreSum;
        }
    }
}
