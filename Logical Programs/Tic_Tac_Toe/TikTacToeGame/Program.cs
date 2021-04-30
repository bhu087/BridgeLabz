using System;

namespace TikTacToeGame
{
    class Program
    {
        public static string[] Board = new string[9];
        public void DisplayFields()
        {
            Console.Clear();
            Console.WriteLine("{0} | {1} | {2}", Board[0], Board[1], Board[2]);
            Console.WriteLine("{0} | {1} | {2}", Board[3], Board[4], Board[5]);
            Console.WriteLine("{0} | {1} | {2}", Board[6], Board[7], Board[8]);
        }
        static void Main(string[] args)
        {
            Program pgrm = new Program();
            pgrm.DisplayFields();
        }
    }
}
