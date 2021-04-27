﻿using Cash_Counter.UtilityForFileOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_Counter
{
    class CashCounterControl
    {
        public void CounterControl()
        {
            CashCounterLogic cashCounterLogic = new CashCounterLogic();
            CustomerDetails customerDetails = new CustomerDetails();
            AccountControl accountControl = new AccountControl();
            long accountNumber;
            int isStop = 0;
            while (isStop != 5)
            {
                Console.WriteLine("Enter 1 for Add to Counter");
                Console.WriteLine("Enter 2 for service is Over to customer");
                Console.WriteLine("Enter 3 Size of Counter");
                Console.WriteLine("Enter 4 Is Counter Empty");
                Console.WriteLine("Enter 6 for Display Customers in Queue");
                Console.WriteLine("Enter 7 for Give Service to Customer");
                Console.WriteLine("Enter 5 to stop the service");
                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Customer Account Number");
                            try
                            {
                               accountNumber  = long.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Account Number");
                                Console.WriteLine(e.Message);
                                return;
                            }
                            customerDetails = accountControl.GetCustomer(accountNumber);
                            if (customerDetails.IsRegisteredCustomer)
                            {
                                if (!cashCounterLogic.IsCustomerInQueue(customerDetails.Name))
                                {
                                    cashCounterLogic.AddToQueue(customerDetails.Name);
                                    Console.WriteLine("{0} Added to Queue", customerDetails.Name);
                                }
                                else
                                {
                                    Console.WriteLine("User already in queue");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Customers Registered with this ID");
                            }
                            break;
                        case 2:
                            cashCounterLogic.DeleteFromQueue();
                            break;
                        case 3:
                            Console.WriteLine("Size of Queue is {0}", cashCounterLogic.SizeOfCounter());
                            break;
                        case 4:
                            bool status = cashCounterLogic.IsEmpty();
                            if (status == true)
                            {
                                Console.WriteLine("Queue is empty");
                            }
                            else
                            {
                                Console.WriteLine("Queue is Not Empty");
                            }
                            break;
                        case 5:
                            isStop = 5;
                            break;
                        case 6:
                            cashCounterLogic.DisplayCustomers();
                            break;
                        case 7:
                            cashCounterLogic.ServiceToCustomer("Deposit");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {

                }
            }
            
        }
    }
}
