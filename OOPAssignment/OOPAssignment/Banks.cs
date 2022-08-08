using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
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
}
