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

