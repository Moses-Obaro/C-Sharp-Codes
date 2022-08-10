namespace InecApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            VoterDataBase newDB = new VoterDataBase();
            newDB.DisplayDB(newDB.existingDataBase);
            Console.WriteLine();
            Console.WriteLine("Displaying database with only single entries");
            string[] singleEntries = newDB.RemoveDuplicateEntries(newDB.existingDataBase);
            Console.WriteLine();
            Console.WriteLine();
            newDB.DisplayCitizenData(singleEntries);

            string[] updatedDB = newDB.RegisterCitizen(singleEntries);

            newDB.DisplayDB(updatedDB);
            //newDB.DisplayCitizenData(newDB.RemoveDuplicateEntries(newDB.existingDataBase));
            

            
        }
    }
}