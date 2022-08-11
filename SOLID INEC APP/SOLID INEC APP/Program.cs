namespace SOLID_INEC_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            GetVotersCount.CountDoubleRegistries(VotersData.existingDataBase);
            RemoveDuplicateEntry.RemoveDuplicateEntries(VotersData.existingDataBase);
        }
    }
}