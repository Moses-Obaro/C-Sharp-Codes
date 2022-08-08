using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Hotel : Building
    {
        //public override string buildingName(string buildingName);

        public void DisplayRooms(int numOfRooms)
        {
            Console.WriteLine("There are {0} rooms in this hotel", numOfRooms);
        }

        // polymorphism concept
        public override void BuildingType()
        {
            Console.WriteLine("This is a hotel");
        }

    }
}
