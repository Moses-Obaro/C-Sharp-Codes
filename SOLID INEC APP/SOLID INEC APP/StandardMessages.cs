using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_INEC_APP
{
    /// <summary>
    /// This class contains all the messages that will be displayed in the Application.
    /// All you need do is fetch from the class the method you want
    /// The methods are marked static for easy access; without having to create an instance of the class.
    /// </summary>
    internal class StandardMessages
    {
        /// <summary>
        /// This displays the welcome message
        /// </summary>
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the multi-registered voter remover App.");
        }
        /// <summary>
        /// This displays a message for those having single entries 
        /// </summary>
        public static void StartSingleEntryDisplay()
        {
            Console.WriteLine("Displaying database with only single entries");
        }


        /// <summary>
        /// Starts the double entry display.
        /// </summary>
        public static void StartDoubleEntryDisplay()
        {
            Console.WriteLine("The following voters have more than one registration entry");
            Console.WriteLine();
        }


        /// <summary>
        /// This displays a message for those with multiple entries
        /// It accepts two parameters a string and an integer
        /// The string and integer are key value pairs of a dictionary item
        /// </summary>
        /// <param name="item" name="value"></param>
        public static void DoublyEnteredDisplayMessage(string item, int value)
        {
            Console.Write($"The voter {item} is registered \t");
            Console.WriteLine($"{value} time(s).");
        }

        /// <summary>
        /// This displays a message for those registered in the database whether they have multiple enteries or not
        /// </summary>
        public static void DisplayRegisteredVotersMessage()
        {
            Console.WriteLine("These are the currently registered citizens in our voters data base: ");
        }

        /// <summary>
        /// Displays the full database welcome message.
        /// </summary>
        public static void DisplayFullDBMessage()
        {
            Console.WriteLine("Displaying full DataBase......");
            Console.WriteLine();
        }

        /// <summary>
        /// This displays a message to notify the user that double entries are being removed from the database.
        /// </summary>
        public static void RemovingEntriesMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Removing double entries from DataBase......");
            Console.WriteLine();
        }
    }
}
