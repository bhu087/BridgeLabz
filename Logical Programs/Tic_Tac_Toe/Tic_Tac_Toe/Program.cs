using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfTiks = 9;
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            while (NumberOfTiks > 0)
            {
                if (true)
                {
                    ticTacToeGameOver.DisplayFields();
                    ticTacToeGameOver.Insert(1,"0");
                    ticTacToeGameOver.DisplayFields();
                    NumberOfTiks = 0;
                }
            }
            
        }
    }
}
