using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_INEC_APP
{
    /// <summary>
    /// This class is for strictly removing duplicate entries
    /// </summary>
    internal class RemoveDuplicateEntry
    {

        /// <summary>
        /// This method removes the duplicate entries.
        /// It first displays the database with duplicate enteries
        /// And then displays the database with single enteries
        /// It accepts a string[] array of names
        /// </summary>
        /// <param name="votersData"></param>
        public static void RemoveDuplicateEntries(string[] votersData)
        {
            votersData = VotersData.existingDataBase;
            DisplayVotersDB.DisplayFullDataBase(votersData);
            StandardMessages.RemovingEntriesMessage();
            string[] distinctVotersData = votersData.Distinct().ToArray();
            DisplayVotersDB.DisplaySingleEntries(distinctVotersData);
        }
    }
}
