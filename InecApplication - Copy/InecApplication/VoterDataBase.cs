using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InecApplication
{
    internal class VoterDataBase
    {
        // Sample database containing doubly-registered voters
        public string[] existingDataBase = new string[]
                                { "Mahfooz Abubakar", "TemilOluwa Adebowale","Ayobola Adeboye",
                           "Olawumi Adedire","Tosin Adefila","Olusegun Akinnola",
                            "John Areola", "Abiola Ayangunna", "Ibrahim Dahiru",
                            "Nasiru Danjuma", "Adeshina Falade", "Ahmad Haruna",
                            "Alexandra Ighodaro", "Oluchi Joseph", "Maclaurin Martin",
                            "Victor Michael", "Edna Nwokedi",
                            "Nwosu-Madueke Vincent","Oluwakemi Odili", "Odunayo Dada",
                            "Yusuf Ogunbode", "Samuel Ogunremi", "Oluwaseyi Okere",
                            "Oluwatimilehin Oladipo", "OgoKristi Oni","Abimbola Onifade",
                            "Peculiar Onugbolu", "Abayomi Oyaifo", "Abasiama Udofa",
                            "Mahfooz Abubakar", "TemilOluwa Adebowale","Ayobola Adeboye",
                            "Olawumi Adedire","Tosin Adefila","Olusegun Akinnola",
                            "John Areola", "Abiola Ayangunna", "Ibrahim Dahiru",
                            "Nasiru Danjuma", "Adeshina Falade", "Ahmad Haruna",
                            "Alexandra Ighodaro", "Oluchi Joseph", "Maclaurin Martin",
                            "Victor Michael", "Moses Obaro", "Edna Nwokedi",
                            "Nwosu-Madueke Vincent","Oluwakemi Odili", "Odunayo Dada",
                            "Yusuf Ogunbode", "Samuel Ogunremi", "Oluwaseyi Okere",
                            "Oluwatimilehin Oladipo", "OgoKristi Oni","Abimbola Onifade",
                            "Peculiar Onugbolu", "Abayomi Oyaifo", "Abasiama Udofa"};


        // This method adds yet-to-be registered voters to the existing dataBase
        // If they already exist, they are not registered
        public string[] RegisterCitizen(string[] existingDB)
        {
            existingDB = existingDataBase.Distinct().ToArray();
            SortedSet<string> existingDataBaseSet = new SortedSet<string>(existingDB);

            Console.Write("How many citizens are being registered: ");
                if (int.TryParse(Console.ReadLine(), out int num))
            {
            }
                else
            {
                Console.WriteLine("Wrong value entered");
            }
            
            int votersNumber = num;

                for (int i = 0; i < votersNumber; i++)
                {
                    Console.Write("Enter voter's name (First_name Last_name): ");
                    string? votersDetails = Console.ReadLine();
                    existingDataBaseSet.Add(votersDetails);
                }
                string[] updatedDB = existingDataBaseSet.ToArray();
                return updatedDB;
            }
        // This method gets the count of votes per voters and displays those with duplicate entries
        // It uses a dictionary with the voter names as keys and the count as the value
        public void GetVotersCount(string[] votersData)
        {
            string[] names = votersData;
            Dictionary<string, int> distinctNames = new Dictionary<string, int>();

            foreach (string item in names)
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
            Console.WriteLine("The following voters have more than one registration entry");
            foreach (var item in distinctNames)
            {
                if (item.Value > 1)
                {
                    Console.Write($"The voter {item.Key} is registered \t");
                    Console.WriteLine($"{item.Value} time(s).");
                }
            }
        }
        // This method removes duplicate entries
        public string[] RemoveDuplicateEntries(string[] votersData)
        {
            votersData = existingDataBase.Distinct().ToArray();
            return votersData;
        }
        // This method displays the  updated database of voters
        // Every voter has a single entry
        public void DisplayCitizenData(string[] Array)
        {
            Console.WriteLine("This is the updated list of registered citizens in our voters data base: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"Voter {i + 1}: \t{Array[i]}");
            }
        }

        // This method displays the existing database of registered voters
        public void DisplayDB(string[] dataBase)
        {
            Array.Sort(dataBase, StringComparer.CurrentCultureIgnoreCase);
            Console.WriteLine("These are the currently registered citizens in our voters data base: ");
            for (int i = 0; i < dataBase.Length; i++)
            {
                Console.WriteLine($"Voter {i + 1}: {dataBase[i]}");
            }
        }
    }


}
    