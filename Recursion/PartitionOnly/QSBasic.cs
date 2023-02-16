﻿using System;
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

        public int partitionIt (int left, int right)
        {
            int pivot = intArray[right];
            int leftMark = left - 1; //pre incremented
            int rightMark = right; //pre decremented
            while (true)
            {
                while (intArray[++leftMark] < pivot) ;
                while (rightMark > 0 && intArray[--rightMark] > pivot) ;
                if (leftMark >= rightMark) break;
                else swap(leftMark, rightMark);
            }
            swap(leftMark, right);
            return leftMark;
        }
        void swap(int Num1, int Num2)
        {
            int temp = intArray[Num1];
            intArray[Num1] = intArray[Num2];
            intArray[Num2] = temp;
              
        }

        public void recQuickSort(int left, int right)
        {
            if (right - left <= 0)
            {
                return;
            }
            int pivotIndex = partitionIt(left, right);
            recQuickSort(left, pivotIndex - 1);
            recQuickSort(pivotIndex + 1, right);
        }


    }
}

