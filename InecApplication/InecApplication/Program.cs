namespace InecApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            VoterDataBase newDB = new VoterDataBase();
            //newDB.DisplayExistingDB();
           
            newDB.GetVotersCount(newDB.existingDataBase);
            Console.WriteLine();
            Console.WriteLine();
            newDB.DisplayCitizenData(newDB.RemoveDuplicateEntries(newDB.existingDataBase));
            

            
        }
    }
}