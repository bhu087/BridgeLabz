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
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Main control Within this</param>
        public static void Main(string[] args)
        {
            int numberOfTiks = 9;
            Program p = new Program();
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            Console.WriteLine("Do you want to play/again press N for No or any key for Yes");
            string choose = Console.ReadLine().ToLower();
            while (choose != "n")
            {
                while (numberOfTiks > 0)
                {
                    ticTacToeGameOver.DisplayFields();
                    if (numberOfTiks > 0)
                    {
                        numberOfTiks -= 1;
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

                    if (numberOfTiks > 0)
                    {
                        numberOfTiks -= 1;
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
            }
            
            Console.WriteLine("Game Over");
        }

        /// <summary>
        /// player One Control
        /// </summary>
        public void PlayerOne()
        {
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            try
            {
                Console.WriteLine("Enter a position");
                int position = int.Parse(Console.ReadLine());
                if (position >= 0 && position < 9)
                {
                    bool isInserted = ticTacToeGameOver.Insert(position, "*");
                    if (isInserted == false)
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

        /// <summary>
        /// Player Two Conditions
        /// </summary>
        public void PlayerTwo()
        {
            TicTacToeGameOver ticTacToeGameOver = new TicTacToeGameOver();
            try
            {
                Console.WriteLine("Enter a position");
                int position = int.Parse(Console.ReadLine());
                if (position >= 0 && position < 9)
                {
                    bool isInserted = ticTacToeGameOver.Insert(position, "0");
                    if (isInserted == false)
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
    }
}
