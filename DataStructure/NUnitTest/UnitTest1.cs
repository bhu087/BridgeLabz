using Cash_Counter;
using Cash_Counter.UtilityForFileOperations;
using NUnit.Framework;

namespace NUnitTest
{
    public class Tests
    {
        [Test]
        public void IfSendTheAccountNumber_ItWillCheckTheCustomerRegistrationStatus_SendCustomerDataFalse()
        {
            AccountControl accountControl = new AccountControl();
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails = accountControl.GetCustomer(123123123);
            Assert.IsFalse(customerDetails.IsRegisteredCustomer);
        }

        [Test]
        public void IfSendTheAccountNumber_ItWillCheckTheCustomerRegistrationStatus_SendCustomerDataTrue()
        {
            AccountControl accountControl = new AccountControl();
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails = accountControl.GetCustomer(123456789);
            Assert.IsTrue(customerDetails.IsRegisteredCustomer);
        }

        [Test]
        public void IfUpdateTheCustomerBalance_SendTrue()
        {
            AccountControl accountControl = new AccountControl();
            bool status = accountControl.UpdateBalance(1234512345, 1000);
            Assert.IsTrue(status);
        }
        [Test]
        public void DeleteFromTheQueue_OnlyQueueIsNotEmpty()
        {
            CashCounterLogic cashCounterLogic = new CashCounterLogic();
            bool status = cashCounterLogic.DeleteFromQueue();
            Assert.IsFalse(status);
        }

        [Test]
        public void IfCustomerAlreadyPresentINQueue_SendTrue()
        {
            CashCounterLogic cashCounterLogic = new CashCounterLogic();
            bool status = cashCounterLogic.IsCustomerInQueue(123456789);
            Assert.IsFalse(status);
        }
    }
}