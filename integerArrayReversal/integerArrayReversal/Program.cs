﻿using System;
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
            int i = 0;
            int j = length - 1;
            while (i < j)
            {
                var temp = intArray[i];
                intArray[i] = intArray[j];
                intArray[j] = temp;
                i++;
                j--;
            }


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
