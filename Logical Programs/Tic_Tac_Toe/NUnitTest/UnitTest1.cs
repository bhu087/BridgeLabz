using NUnit.Framework;
using Tic_Tac_Toe;

namespace NUnitTest
{
    public class Tests
    { 
        [Test]
        public void Test1()
        {
            var ticTacToe = new TicTacToeGameOver();
            bool result = ticTacToe.GameCheck();
            Assert.IsTrue(!result);
        }
        [Test]
        public void Test2()
        {
            var ticTacToe = new TicTacToeGameOver();
            bool result = ticTacToe.Insert(0,"*");
            Assert.IsTrue(result);
        }
        [Test]
        public void Test3()
        {
            var ticTacToe = new TicTacToeGameOver();
            bool result = ticTacToe.Insert(0, "*");
            Assert.IsTrue(!result);
        }
    }
}