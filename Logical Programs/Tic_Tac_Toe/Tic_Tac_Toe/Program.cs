/////------------------------------------------------------------------------
////<copyright file="Program.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Tic_Tac_Toe
{
    using System;

    /// <summary>
    /// Main program
    /// </summary>
    public class Program
    {
        public void PlayerOne()
        {
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            try
            {
                int position = Int32.Parse(Console.ReadLine());
                if (position > 0 && position < 9)
                {
                    bool IsInserted = ticTacToeGameOver.Insert(position, "*");
                    if (IsInserted == false)
                    {
                        Console.WriteLine("Already Place is occupied Please Enter other place");
                    }
                    this.PlayerOne();
                }
                else
                {
                    Console.WriteLine("Enter a Correct places between 0 to 8");
                    this.PlayerOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.PlayerOne();
            }
        }
        public void PlayerTwo()
        {
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
        }
        public static void Main(string[] args)
        {
            int NumberOfTiks = 9;
            Program p = new Program();
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            while (NumberOfTiks > 0)
            {
                NumberOfTiks -= 1;
                p.PlayerOne();
            }
            
        }
        
    }
}
