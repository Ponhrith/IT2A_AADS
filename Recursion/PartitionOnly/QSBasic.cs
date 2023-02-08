using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionOnly
{
    internal class QSBasic
    {
        int[] intArray;

        public void GenerateRandomInteger(int length)
        {
            {// The rand() is a Lib function to generate a constant set of random Integers
                intArray = new int[length];
                Random r = new Random();
                for (int k = 0; k < length; k++)
                    intArray[k] = r.Next() % 100 + 1; // Integers from 1 to 99
            }

           
        }
        public QSBasic(int size)
        {
            GenerateRandomInteger(size);
        }
        public void DisplayArray()
        {
            int length = intArray.Length;
            Console.Write("Index: ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", k);
            Console.WriteLine();
            Console.Write("data:  ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", intArray[k]);
            Console.WriteLine();
        }
    }
}

