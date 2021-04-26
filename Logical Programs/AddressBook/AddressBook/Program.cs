/////------------------------------------------------------------------------
////<copyright file="Program.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------
namespace AddressBook
{
    /// <summary>
    /// Starting of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">parameter</param>
        public static void Main(string[] args)
        {
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            addressBookOperations.AddressOperationsSelection();
        }
    }
}
