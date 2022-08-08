namespace OOPAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel();
            hotel1.NumberOfRooms = 4;
            // hotel1 inherits the DisplayRooms() method from the biulding class
            hotel1.DisplayRooms(hotel1.NumberOfRooms);
            hotel1.BuildingLocation = "hotel1";

            // hotel1 inherits the DisplayRooms() method from the biulding class - INHERITANCE
            Churches church1 = new Churches();
            church1.BuildingLocation = "Abuja";
        }
    }
}