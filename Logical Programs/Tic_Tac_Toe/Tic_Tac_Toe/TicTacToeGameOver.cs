/////------------------------------------------------------------------------
////<copyright file="TicTacToeGameOver.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------
namespace Tic_Tac_Toe
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Game tracker
    /// </summary>
    public class TicTacToeGameOver
    {
        /// <summary>
        /// Declaring a 3 D Array
        /// </summary>
        public static string[,] Array = new string[3, 3]
        {
            { " ", " ", " " },
            { " ", " ", " " },
            { " ", " ", " " }
        };

        /// <summary>
        /// Display a current Array
        /// </summary>
        public void DisplayFields()
        {
            string[,] fields = Array;
            Console.Clear();
            Console.WriteLine("{0} | {1} | {2}", fields[0, 0], fields[0, 1], fields[0, 2]);
            Console.WriteLine("{0} | {1} | {2}", fields[1, 0], fields[1, 1], fields[1, 2]);
            Console.WriteLine("{0} | {1} | {2}", fields[2, 0], fields[2, 1], fields[2, 2]);
        }

        /// <summary>
        /// Check Weather game over or not.
        /// </summary>
        /// <returns> true or false</returns>
        public bool GameCheck()
        {
            if ((Array[0, 0].Equals(Array[0, 1]) && Array[0, 0].Equals(Array[0, 2]) && Array[0, 0].Equals("*")) ||
                (Array[0, 0].Equals(Array[0, 1]) && Array[0, 0].Equals(Array[0, 2]) && Array[0, 0].Equals("0")))
            {
                return true;
            }
            else if ((Array[1, 0].Equals(Array[1, 1]) && Array[1, 0].Equals(Array[1, 2]) && Array[1, 0].Equals("*")) ||
                (Array[1, 0].Equals(Array[1, 1]) && Array[1, 0].Equals(Array[1, 2]) && Array[1, 0].Equals("0")))
            {
                return true;
            }
            else if ((Array[2, 0].Equals(Array[2, 1]) && Array[2, 0].Equals(Array[2, 2]) && Array[2, 0].Equals("*")) ||
                (Array[2, 0].Equals(Array[2, 1]) && Array[2, 0].Equals(Array[2, 2]) && Array[2, 0].Equals("0")))
            {
                return true;
            }
            ////*************************************************************************
            else if ((Array[0, 0].Equals(Array[1, 0]) && Array[0, 0].Equals(Array[2, 0]) && Array[0, 0].Equals("*")) ||
                (Array[0, 0].Equals(Array[1, 0]) && Array[0, 0].Equals(Array[2, 0]) && Array[0, 0].Equals("0")))
            {
                return true;
            }
            else if ((Array[0, 1].Equals(Array[1, 1]) && Array[0, 1].Equals(Array[2, 1]) && Array[0, 1].Equals("*")) ||
                (Array[0, 1].Equals(Array[1, 1]) && Array[0, 1].Equals(Array[2, 1]) && Array[0, 1].Equals("0")))
            {
                return true;
            }
            else if ((Array[0, 2].Equals(Array[1, 2]) && Array[0, 2].Equals(Array[2, 2]) && Array[0, 2].Equals("*")) ||
                (Array[0, 2].Equals(Array[1, 2]) && Array[0, 2].Equals(Array[2, 2]) && Array[0, 2].Equals("0")))
            {
                return true;
            }
            ////*************************************************************************
            else if ((Array[0, 0].Equals(Array[1, 1]) && Array[0, 0].Equals(Array[2, 2]) && Array[0, 0].Equals("*")) ||
                (Array[0, 0].Equals(Array[1, 1]) && Array[0, 0].Equals(Array[2, 2]) && Array[0, 0].Equals("0")))
            {
                return true;
            }
            else if ((Array[0, 2].Equals(Array[1, 1]) && Array[0, 2].Equals(Array[2, 0]) && Array[0, 2].Equals("*")) ||
                (Array[0, 2].Equals(Array[1, 1]) && Array[0, 2].Equals(Array[2, 0]) && Array[0, 2].Equals("0")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Insert the player symbols in respective places
        /// </summary>
        /// <param name="pos"> 1 to 9</param>
        /// <param name="playerSymbol"> * or 0</param>
        /// <returns> true to false</returns>
        public bool Insert(int pos, string playerSymbol)
        {
            string[,] fields = Array;
            switch (pos)
            {
                case 0:
                    if (fields[0, 0].Equals("0") || fields[0, 0].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[0, 0] = playerSymbol;
                        return true;
                    }

                case 1:
                    if (fields[0, 1].Equals("0") || fields[0, 1].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[0, 1] = playerSymbol;
                        return true;
                    }

                case 2:
                    if (fields[0, 2].Equals("0") || fields[0, 2].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[0, 2] = playerSymbol;
                        return true;
                    }

                case 3:
                    if (fields[1, 0].Equals("0") || fields[1, 0].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[1, 0] = playerSymbol;
                        return true;
                    }

                case 4:
                    if (fields[1, 1].Equals("0") || fields[1, 1].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[1, 1] = playerSymbol;
                        return true;
                    }

                case 5:
                    if (fields[1, 2].Equals("0") || fields[1, 2].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[1, 2] = playerSymbol;
                        return true;
                    }

                case 6:
                    if (fields[2, 0].Equals("0") || fields[2, 0].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[2, 0] = playerSymbol;
                        return true;
                    }

                case 7:
                    if (fields[2, 1].Equals("0") || fields[2, 1].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[2, 1] = playerSymbol;
                        return true;
                    }

                case 8:
                    if (fields[2, 2].Equals("0") || fields[2, 2].Equals("*"))
                    {
                        return false;
                    }
                    else
                    {
                        fields[2, 2] = playerSymbol;
                        return true;
                    }
            }

            return false;
        }
    }
}
