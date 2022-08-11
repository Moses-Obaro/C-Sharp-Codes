using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_INEC_APP
{
    /// <summary>
    /// This class contains methods for removing double entries
    /// </summary>
    internal class DisplayVotersDB
    {
        /// <summary>
        /// Displays the full data base.
        /// It accepts the original database of voters containing doubly-registered voters as its parameter
        /// </summary>
        /// <param name="dataBase">The data base.</param>
        public static void DisplayFullDataBase(string[] dataBase)
        {
            StandardMessages.DisplayFullDBMessage();
            Array.Sort(dataBase, StringComparer.CurrentCultureIgnoreCase);
            StandardMessages.DisplayRegisteredVotersMessage();
            for (int i = 0; i < dataBase.Length; i++)
            {
                Console.WriteLine($"Voter {i + 1}: {dataBase[i]}");
            }
        }

        /// <summary>
        /// Displays the double entries in the existing database of users
        /// </summary>
        /// <param name="doubleVotersData">The voters data.</param>
        public static void DisplayDoubleEntries(string[] doubleVotersData)
        {
            for (int i = 0; i < doubleVotersData.Length; i++)
            {
                Console.WriteLine($"Voter {i + 1}: {doubleVotersData[i]}");
            }

        }
        /// <summary>
        /// Displays the single entries in a database.
        /// it accepts an array of distinct names as its parameter
        /// </summary>
        /// <param name="distinctVotersData">The voters data.</param>
        public static void DisplaySingleEntries(string[] distinctVotersData)
        {
            StandardMessages.StartSingleEntryDisplay();
            for (int i = 0; i < distinctVotersData.Length; i++)
            {
                Console.WriteLine($"Voter {i + 1}: {distinctVotersData[i]}");
            }

        }
    }
}
