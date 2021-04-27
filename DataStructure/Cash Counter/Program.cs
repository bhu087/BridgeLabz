/////------------------------------------------------------------------------
////<copyright file="Program.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Cash_Counter
{
    using System;

    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CashCounterControl cashCounterControl = new CashCounterControl();
            cashCounterControl.CounterControl();
        }
    }
}
