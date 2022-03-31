using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace ConsoleApp1
{
    class Game
    {
        int compPick, userWin, compWin;
        Random rnum = new Random();

        public Game()
        {
            userWin = 0;
            compWin = 0;
        }

        public int GetCompPick()
        {
            return compPick = rnum.Next(1, 3);
        }

        public int Winner(int userInput)
        {
            if (userInput == 1)
            {
                if(compPick == 1)
                {
                    WriteLine("The computer chose rock, it's a tie");
                    return 0;
                }
                else if (compPick == 2)
                {
                    WriteLine("The computer chose paper, you lose");
                    return -10;
                }
                else
                {
                    WriteLine("The computer chose scissors, you win");
                    return 20;
                }
            }
            if (userInput == 2)
            {
                if (compPick == 1)
                {
                    WriteLine("The computer chose rock, you win");
                    return 20;
                }
                else if (compPick == 2)
                {
                    WriteLine("The computer chose paper, it's a tie");
                    return 0;
                }
                else
                {
                    WriteLine("The computer chose scissors, you lose");
                    return -10;
                }
            }
            if (userInput == 3)
            {
                if (compPick == 1)
                {
                    WriteLine("The computer chose rock,  you lose");
                    return -10;
                }
                else if (compPick == 2)
                {
                    WriteLine("The computer chose paper, you win");
                    return 20;
                }
                else
                {
                    WriteLine("The computer chose scissors, it's a tie");
                    return 0;
                }
            }
            return 0;
        }

        public string History(int userInput)
        {
            if (userInput == 1)
            {

                if (compPick == 2)
                {
                    compWin++;
                    
                }
                else if (compPick == 3)
                {
                    userWin++;
                }
            }
            if (userInput == 2)
            {
                if (compPick == 1)
                {
                    userWin++;

                }
                else if (compPick == 3)
                {
                    compWin++;

                }
            }
            if (userInput == 3)
            {
                if (compPick == 1)
                {
                    compWin++;

                }
                else if (compPick == 2)
                {
                    userWin++;

                }
            }
            return "the score is now User: " + userWin + "       comp: " + compWin;
        }
        public int GetUserWin()
        {
            return userWin;
        }

        public int GetCompWin()
        {
            return compWin;
        }
    }
}