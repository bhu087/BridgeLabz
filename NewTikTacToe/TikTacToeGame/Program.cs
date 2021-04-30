using System;
namespace TikTacToeGame
{
    class Program
    {
        public static string[] Board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        
        static void Main(string[] args)
        {
            int totalTics = 9;
            DisplayFields();
            while (totalTics > 0 )
            {
                if (totalTics > 0 && !GameCheck())
                {
                    UserPlay();
                    totalTics--;
                    DisplayFields();
                    if (GameCheck())
                    {
                        Console.WriteLine("User Wins");
                        break;
                    }
                }
                if (totalTics > 0 && !GameCheck())
                {
                    CompPlay();
                    totalTics--;
                    Console.WriteLine(totalTics);
                    DisplayFields();
                    if (GameCheck())
                    {
                        Console.WriteLine("Comp Wins");
                        break;
                    }
                }
                if (totalTics == 0)
                {
                    Console.WriteLine("No one wins");
                }
            }
            void DisplayFields()
            {
                Console.Clear();
                Console.WriteLine("              |     |      ");
                Console.WriteLine("           {0}  |  {1}  |  {2}", Board[0], Board[1], Board[2]);
                Console.WriteLine("         _____|_____|_____ ");
                Console.WriteLine("              |     |      ");
                Console.WriteLine("           {0}  |  {1}  |  {2}", Board[3], Board[4], Board[5]);
                Console.WriteLine("         _____|_____|_____ ");
                Console.WriteLine("              |     |      ");
                Console.WriteLine("           {0}  |  {1}  |  {2}", Board[6], Board[7], Board[8]);
                Console.WriteLine("              |     |      ");
            }
            void UserPlay()
            {
                int fieldOption;
                Console.WriteLine("Enter Your Field");
                try
                {
                    fieldOption = int.Parse(Console.ReadLine());
                    if (!fieldCheck(fieldOption))
                    {
                        Console.WriteLine("Wrong entry try again");
                        UserPlay();
                        return;
                    }
                    Board[fieldOption] = "*";
                }
                catch
                {
                    Console.WriteLine("Wrong entry try again");
                    UserPlay();
                    return;
                }
            }

            void CompPlay()
            {
                int fieldOption;
                Random random = new Random();
                fieldOption = random.Next(0, 8);
                if (!fieldCheck(fieldOption))
                {
                    CompPlay();
                    return;
                }
                Board[fieldOption] = "0";
            }
            bool fieldCheck(int fieldPosition)
            {
                if (!Board[fieldPosition].Equals("*") && !Board[fieldPosition].Equals("0"))
                {
                    return true;
                }
                return false;
            }
            bool GameCheck()
            {
                for (int i = 0; i < 7; i = i + 3)
                {
                    if (Board[i].Equals(Board[i + 1]) && Board[i + 1].Equals(Board[i + 2]))
                    {
                        return true;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (Board[i].Equals(Board[i + 3]) && Board[i + 3].Equals(Board[i + 6]))
                    {
                        return true;
                    }
                }
                if (Board[0].Equals(Board[4]) && Board[4].Equals(Board[8]))
                {
                    return true;
                }
                if (Board[2].Equals(Board[4]) && Board[4].Equals(Board[6]))
                {
                    return true;
                }
                return false;
            }
        }

    }
}
