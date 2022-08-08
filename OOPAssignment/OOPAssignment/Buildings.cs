using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public abstract class Building
    {
        // encapsulation in action
        private int numberOfRooms;
        private string nameOfBuilding, buildingLocation;
        public string NameOfBuilding
        {
            get { return nameOfBuilding; }
        }
        public string BuildingLocation
        {
            get { return buildingLocation; }
            set { buildingLocation = value; }
        }
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }
        //end of encapsulation
        public virtual void DisplayBuilding()
        {
            Console.WriteLine("I am a building");
        }

        // Abstraction in action
        public abstract void BuildingType();
    }

    // INHERITANCE concept
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

    internal class Bank : Building
    {
        public void VaultAvailable(bool vault)
        {
            if (vault)
            {
                Console.WriteLine("This bank has a vault.");
            }
            else
            {
                Console.WriteLine("This bank has no vault");
            }
        }
        public override void BuildingType()
        {
            Console.WriteLine("This is a Bank.");
        }
    }

    internal class Church : Building
    {
        public override void BuildingType()
        {
            Console.WriteLine("This is a church.");
        }
    }
}
