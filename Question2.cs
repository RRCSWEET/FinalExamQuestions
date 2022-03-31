using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pick, money = 100;
            int compPick, userWin, computerWin;
            Game Game1 = new Game();
            do
            {
                pick = UserInput("\nPlease select your choice (1 for rock, 2 for paper, 3 for scissors, 4 to exit game)");
                if (pick == 4)
                {
                    WriteLine("You have chose to leave");
                    break;
                }
                compPick = Game1.GetCompPick();
                money = money + Game1.Winner(pick);
                WriteLine("you have $" + money);
                WriteLine(Game1.History(pick));
                computerWin = Game1.GetCompWin();
                userWin = Game1.GetUserWin();


                if (userWin == 4)
                {
                    WriteLine("you have won against the computer.");
                    break;
                }
                else if (computerWin == 4)
                {
                    WriteLine("you have lost to the computer");
                    break;
                }
                else if (money <= 0)
                {
                    WriteLine("You are out of money");
                    break;
                }

            } while (money > 0 || pick != 4);
        }

        static int UserInput(string val)
        {
            string input;
            int pick = 0;
            while (pick != 1 && pick != 2 && pick != 3 && pick != 4)
            {
                WriteLine(val);
                input = ReadLine();
                pick = int.Parse(input);

                if (pick == 4)
                {
                    WriteLine("You have left the game.");
                    break;
                }
            }
            return pick;
        }
    }
}








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

