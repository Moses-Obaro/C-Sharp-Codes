using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_INEC_APP
{
    internal class GetVotersCount
    {
        /// <summary>
        /// Counts the double registries.
        /// </summary>
        /// <param name="votersData">The voters data in thev existing database.</param>
        public static void CountDoubleRegistries(string[] votersData)
        {
            StandardMessages.StartDoubleEntryDisplay();
            votersData = VotersData.existingDataBase;
            Dictionary<string, int> distinctNames = new Dictionary<string, int>();

            foreach (string item in votersData)
            {
                if (item != "")
                {
                    if (distinctNames.ContainsKey(item) == false)
                    {
                        distinctNames.Add(item, 1);
                    }
                    else
                    {
                        distinctNames[item]++;
                    }
                }
            }
 
            foreach (var item in distinctNames)
            {
                if (item.Value > 1)
                {
                    StandardMessages.DoublyEnteredDisplayMessage(item.Key, item.Value);
                }
            }
        }
    }
}
