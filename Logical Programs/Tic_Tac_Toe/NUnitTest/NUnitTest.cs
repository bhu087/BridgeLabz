/////------------------------------------------------------------------------
////<copyright file="NUnitTest.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace NUnitTest
{
    using NUnit.Framework;
    using Tic_Tac_Toe;

    /// <summary>
    /// Test Cases
    /// </summary>
    public class Tests
    { 
        /// <summary>
        /// Test case one for Game Check
        /// </summary>
        [Test]
        public void Test1()
        {
            var ticTacToe = new TicTacToeGameOver();
            bool result = ticTacToe.GameCheck();
            Assert.IsTrue(!result);
        }

        /// <summary>
        /// Test case 2 for Insert Condition
        /// </summary>
        [Test]
        public void Test2()
        {
            var ticTacToe = new TicTacToeGameOver();
            bool result = ticTacToe.Insert(0, "*");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test case 3 for Insert Condition
        /// </summary>
        [Test]
        public void Test3()
        {
            var ticTacToe = new TicTacToeGameOver();
            bool result = ticTacToe.Insert(0, "*");
            Assert.IsTrue(!result);
        }
    }
}