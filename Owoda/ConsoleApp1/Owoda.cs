using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Owoda
    {
        /* 
         * This method displays the terms and conditions in Owomida
         * K is for Keke
         * B is for Bus
         * MB is for MiniBus
         * BK is for Motor Cycle
         * 
         * It also displays the various toll for various vehicle types
        */
        protected void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Owomida!\n");
            Console.WriteLine("On this app " +
                "\nK is for Keke " +
                "\nB is for Bus" +
                "\nM is for Minibus" +
                "\nBK is for Motorbike" +
                "\n" +
                "\nEnter Y for NURTW members and N for non-members\n");

            Console.WriteLine("Our prices remain: " +
                "\n\tBuses \t  - #1,000" +
                "\n\tMinibus   - #800" +
                "\n\tKeke      - #500" +
                "\n\tMotorbike - #300\n");
        }

        /*
         * This method gets vehicle toll(a fee paid by a driver) based on the vehicle type
         * Buses pay #1,000
         * MiniBuses pay #800
         * Kekes pay #500
         * Bikes pay #300
         * Other vehicle types entered pay #0.00
        */
        protected double GetToll(int counter)
        {
            string vehicle;
            double tollFees;
            Console.Write("\nThis is Driver {0} ", counter);
            Console.Write("\nWhat kind of vehicle is this? ");
            vehicle = Console.ReadLine().ToLower();
            if (vehicle == "b")
            {
                tollFees = 1000;
            }
            else if (vehicle == "m")
            {
                tollFees = 800;
            }
            else if (vehicle == "k")
            {
                tollFees = 500;
            }
            else if (vehicle == "bk")
            {
                tollFees = 300;
            }
            else
            {
                System.Console.WriteLine("Unknown vehicle type");
                tollFees = 0;
            }
            return tollFees;
        }

        /*
         * This method determines if the driver is a member of NURTW or not
         * It also calculates the total cost for n number of trips.
         * Non-members pay the full amount, while members pay 70 percent
        */
        protected double GetMembershipBenefit(double tollFee, int tripNumber)
        {
            double totalCost;
            string membership;
            Console.Write("Are you a member of NURTW? ");
            membership = Console.ReadLine().ToLower();
            if (membership == "y")
            {
                totalCost = 0.7 * tollFee * tripNumber;
            }
            else
            {
                totalCost = tollFee * tripNumber;
            }
            return Math.Round(totalCost, 2);
        }

        /*
         * This method gets the number of trips a driver has made for a day
         */
        protected int GetNumberOfTrips()
        {
            int numberOfTrips = 0;
            Console.Write("How many trips have you embarked on today? ");
            numberOfTrips = Convert.ToInt32(Console.ReadLine());
            return numberOfTrips;
        }

        /*
         * This method calculates the cost per driver
         * It also calculates the total number of money the collector has made for the day
         */
        protected void GetCost()
        {
            int NumOfDrivers = 5;
            double sumTotal = 0;
            for (int i = 0; i < NumOfDrivers; i++)
            {
                double tollFees = GetToll(i + 1);
                int tripNumber = GetNumberOfTrips();
                double getMembershipBenefit = GetMembershipBenefit(tollFees, tripNumber);
                Console.WriteLine("The total payment from Driver {0} is {1}", i + 1, getMembershipBenefit);
                sumTotal += getMembershipBenefit;
            }

            Console.WriteLine("\nThe sum total of payments received today from {0} drivers is {1}", NumOfDrivers, sumTotal);
            Console.WriteLine("");
        }

        /*
         * This method calls the welcomeScreen method and the GetCost method 
         */
        public void Start()
        {
            WelcomeScreen();
            GetCost();
        } 

    }
}
