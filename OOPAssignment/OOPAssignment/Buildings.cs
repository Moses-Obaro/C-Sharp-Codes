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


    
}
