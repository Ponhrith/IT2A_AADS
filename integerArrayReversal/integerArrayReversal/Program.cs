using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerArrayReversal
{
    internal class Program
    {
        static void GenerateRandomIntegers(int[] intArray, int length)
        {// The rand() is a Lib function to generate a constant set of random Integers
            Random r = new Random();
            for (int k = 0; k < length; k++)
                intArray[k] = r.Next() % 100 + 1; // Integers from 1 to 100
        }

        static void DisplayArray(int[] intArray, int length)
        {
            for (int k = 0; k < length; k++)
                Console.Write("{0}, ", intArray[k]);
            Console.WriteLine();

        }

        static void ArrayReversal(int[] intArray, int length)
        {
            // your code
            var itemMoved = false;
            do
            {
                itemMoved = false;
                //loop through every element of the array
                for (int i = 0; i < (length - 1); i++)
                {
                    //compare if the element is greater than the next element, swap them
                    if (intArray[i] > intArray[i + 1])
                    {
                        //if true swap the elements
                        int lowerValue = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = lowerValue;
                        itemMoved = true;//item has moved
                    }
                }
            } while (itemMoved);//if item has moved start from the beginning again


        }



        static void Main(string[] args)
        {
            int[] intArray = new int[15];
            int length;
            do
            {
                Console.Write("Enter number of elements (1-15) for the array: ");
                length = int.Parse(Console.ReadLine());
            } while (length < 1 || length > 15);

            GenerateRandomIntegers(intArray, length);
            Console.WriteLine("The Unsorted array:");
            DisplayArray(intArray, length);

            //BubbleSort(intArray, length);
            ArrayReversal(intArray, length);
            Console.WriteLine("The reversed array:");
            DisplayArray(intArray, length);
            Console.ReadKey();
        }
    }
}
