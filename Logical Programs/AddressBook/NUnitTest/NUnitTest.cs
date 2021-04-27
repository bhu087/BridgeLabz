/////------------------------------------------------------------------------
////<copyright file="Tests.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace NUnitTest
{
    using AddressBook;
    using NUnit.Framework;

    /// <summary>
    /// Test cases
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Test case one for duplicate number
        /// </summary>
        [Test]
        public void Test1()
        {
            var addressBook = new AddressBookLogic();
            bool result = addressBook.DuplicateNumber(123456789);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test case Two for Duplicate number
        /// </summary>
        [Test]
        public void Test2()
        {
            var addressBook = new AddressBookLogic();
            bool result = addressBook.DuplicateNumber(12326546);
            Assert.IsTrue(result);
        }
    }
}