using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsAssignments
{
    /// <summary>
    /// This is the event publisher class
    /// The event HalfWayDone is created using a delegate HalfWayDoneHandler
    /// </summary>
    public class EventPublisher
    {
        public delegate void HalfWayDoneHandler(); //a delegate called HalfWayHandler     
        public event HalfWayDoneHandler HalfWayDone; // An event called HalfWayDone based on the HalfWayDoneHandler delegate

        /// <summary>
        /// This method invokes the HalfWayDone event.
        /// 
        /// </summary>
        protected virtual void HalfWayThere()
        {
            HalfWayDone?.Invoke();
        }
        /// <summary>
        /// This method calls the HalfWayThere() method which invokes the HalfWayDone event
        /// </summary>
        public void OnHalfWayDone()
        {
            HalfWayThere();
            Console.WriteLine("The program is half-way done");
        }

    }

    public static class EventSubscribers
    {
        /// <summary>
        /// This method counts up to thousands thousands.
        /// It raises the event HalfWayDone.
        /// When raised, the event is 
        /// </summary>
        public static void CountInThousands()
        {
            EventPublisher halfDoneEvent = new EventPublisher();

            // Start counting from 0 to 20,000
            EventSubscribers.CountStarted();
            for (int i = 1; i <= 20000; i++) // Counts from 1 to 20000
            {
                if (i == (20000 / 2))
                {
                    Console.WriteLine($"The program is currenty on number {i}");
                     halfDoneEvent.OnHalfWayDone();
                    
                }
            }            
        }

        /// <summary>
        /// Called to signify start of count program
        /// </summary>
        public static void CountStarted()
        {
            Console.WriteLine("Counting has started, counting from 1 to 20,000");
        }

            
    }
}
