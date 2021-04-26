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
                Console.WriteLine("Enter a position");
                int position = Int32.Parse(Console.ReadLine());
                if (position >= 0 && position < 9)
                {
                    bool IsInserted = ticTacToeGameOver.Insert(position, "*");
                    if (IsInserted == false)
                    {
                        Console.WriteLine("Already Place is occupied Please Enter other place");
                        this.PlayerOne();
                    }
                    
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
            try
            {
                Console.WriteLine("Enter a position");
                int position = Int32.Parse(Console.ReadLine());
                if (position >= 0 && position < 9)
                {
                    bool IsInserted = ticTacToeGameOver.Insert(position, "0");
                    if (IsInserted == false)
                    {
                        Console.WriteLine("Already Place is occupied Please Enter other place");
                        this.PlayerTwo();
                    }
                    
                }
                else
                {
                    Console.WriteLine("Enter a Correct places between 0 to 8");
                    this.PlayerTwo();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.PlayerTwo();
            }
        }
        public static void Main(string[] args)
        {
            int NumberOfTiks = 9;
            Program p = new Program();
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            while (NumberOfTiks > 0)
            {
                ticTacToeGameOver.DisplayFields();
                if (NumberOfTiks > 0)
                {
                    NumberOfTiks -= 1;
                    p.PlayerOne();
                    if (ticTacToeGameOver.GameCheck())
                    {
                        ticTacToeGameOver.DisplayFields();
                        Console.WriteLine("User One Wins");
                        break;
                    }
                    ticTacToeGameOver.DisplayFields();
                }
                else
                {
                    Console.WriteLine("No one Wins");
                    break;
                }

                if (NumberOfTiks > 0)
                {
                    NumberOfTiks -= 1;
                    p.PlayerTwo();
                    if (ticTacToeGameOver.GameCheck())
                    {
                        ticTacToeGameOver.DisplayFields();
                        Console.WriteLine("User Two Wins");
                        break;
                    }
                    ticTacToeGameOver.DisplayFields();
                }
                else
                {
                    Console.WriteLine("No one Wins");
                    break;
                }
            }
            Console.WriteLine("Game Over");
            
        }
        
    }
}
