using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsAssignments
{
    /// <summary>
    /// This class uses a delegate to create a callback for a long running task
    /// The class uses the Action delegate to return the percent done
    /// </summary>
    public static class DelegateQuestion2
    {
        public static void DivideByHundred()
        {
            var numbersDivisible = new ArrayList(); 
            Action<int> percentDone = PercentageDone;
            Console.WriteLine("Finding numbers divisible by 100 from 1 to 10000\n");
            for (int i = 1; i <= 10000; i++)
            {
                if (i%100 == 0)
                {
                    Console.WriteLine($"{i} is divisible by 100.");
                    numbersDivisible.Add(i);
                }
                if (i%1000 == 0)
                {
                    percentDone(i);
                }
            }
            Console.Write("The following numbers are divisible by 100 between 0 and 5000: ");
            foreach (var number in numbersDivisible)
            {
                Console.Write($"\t {number}");
            }
            Console.ReadKey();
        }
        public static void PercentageDone(int currentStatus)
        {
            Console.WriteLine($"\nThe program is {(currentStatus/100)} percent done.\n" ); 
        }
    }
}
