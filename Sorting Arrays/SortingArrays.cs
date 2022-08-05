using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrays
{
    internal class SortingArrays
    {
        // This method is to get array size from the user
        protected int GetArraySize()
        {
            int numOfIntegers;
            Console.Write("How many integers do you want in your array: ");
            numOfIntegers = Convert.ToInt32(Console.ReadLine());
            return numOfIntegers;
        }
        
        // This is to get integer array size from user
        protected int[] GetIntegerArray()
        {
            int a = GetArraySize();
            int[] integerArray = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter integer {0}: ", i + 1);
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return integerArray;
        }

        // This is to sort the array in descending order
        protected int[] SortArrayDescending()
        {
            int[] integerArray = GetIntegerArray();
            int numOfIntegers = integerArray.Length;
            for (int i = 0; i < numOfIntegers; i++)
            {
                for (int arraySelector2 = i + 1; arraySelector2 < numOfIntegers; arraySelector2++) //
                {
                    if (integerArray[i] < integerArray[arraySelector2])
                    {
                        int tempValue = integerArray[i];
                        integerArray[i] = integerArray[arraySelector2];
                        integerArray[arraySelector2] = tempValue;
                    }
                }
            }
            return integerArray;
        }

        // This is to sort the array in ascending order
        protected int[] SortArrayAscending()
        {
            int[] integerArray = GetIntegerArray();
            int numOfIntegers = integerArray.Length;
            for (int i = 0; i < numOfIntegers; i++)
            {
                for (int arraySelector2 = i + 1; arraySelector2 < numOfIntegers; arraySelector2++) //
                {
                    if (integerArray[i] > integerArray[arraySelector2])
                    {
                        int tempValue = integerArray[i];
                        integerArray[i] = integerArray[arraySelector2];
                        integerArray[arraySelector2] = tempValue;
                    }
                }
            }
            return integerArray;
        }

        // This is to display the array sorted in descending order
        protected void DisplayResultDescending()
        {
            int[] array = SortArrayDescending();
            Console.WriteLine();
            foreach (int item in array)
            {
                int i = 1;
                Console.WriteLine("Printing position {0}: {1}", i, item);
                i++;
            }
        }

        // This is to display the array sorted in ascending order
        protected void DisplayResultAscending()
        {
            int[] array = SortArrayAscending();
            Console.WriteLine();
            foreach (int item in array)
            {
                int i = 1;
                Console.WriteLine("\nPrinting position {0}: {1}", i, item);
                i++;
            }
        }

        // This is to start the ascending order program
        protected void StartAscending()
        {
            DisplayResultAscending();
        }
        // This is to start the descending order program
        protected void StartDescending()
        {
            DisplayResultDescending();
        }

        // This is to start the program
        public void Start()
        {
            Console.Write("Hello there user! " +
                "\nWelcome to the Array sorting program " +
                "\nWhat operation do you want to perform (A for ascending, D for descending): ");
            string userInput = Convert.ToString(Console.ReadLine()).ToLower();
            if (userInput == "a")
            {
                DisplayResultAscending();
            }
            else if (userInput == "d") 
            { 
                DisplayResultDescending(); 
            }
            else
            {
                Console.WriteLine("Your entry is invalid!!! Try again");
            }
        }
    }
}


