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
            Console.WriteLine("Enter 1 for Add to Counter");
            Console.WriteLine("Enter 2 for service is Over to customer");
            Console.WriteLine("Enter 3 Size of Counter");
            Console.WriteLine("Enter 4 Is Counter Empty");
            try
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        cashCounterLogic.AddToQueue("Bhushan");
                        Console.WriteLine(cashCounterLogic.SizeOfCounter());
                        break;
                    case 2:
                        
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
