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
                        break;
                    case 4:
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
