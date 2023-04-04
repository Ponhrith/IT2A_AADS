using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate an empty Queue
            Cell TopSentinel, BottomSentinel;
            TopSentinel = new Cell();
            BottomSentinel = new Cell();

            TopSentinel.Next = BottomSentinel;
            BottomSentinel.Prev = TopSentinel;

            int x = 0;
            while (x !=5)
            {
                Console.Clear();
                Console.WriteLine("Enter 0 to display the Queue");
                Console.WriteLine("Enter 1 to EnQueue a string");
                Console.WriteLine("Enter 0 to DeQueue");

                Console.WriteLine("Enter any other number to exit.\n\n");
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("Display the Queue: ");
                    for (Cell cell = TopSentinel; cell != null; cell = cell.Next)
                    {
                        Console.WriteLine(cell.Value);
                    }
                }
                else if (x == 1)
                {
                    Console.Write("Enter a name of the string to be enqueue onto the queue: ");
                    string NewName = Console.ReadLine();
                    TopSentinel.enqueue(TopSentinel, NewName);
                }
                else if (x == 2)
                {
                    Console.Write("Enter a name of the string to be dequeue from the queue: ");
                    string Delete = Console.ReadLine();
                    TopSentinel.dequeue(TopSentinel, Delete);
                }
                else break;
                Console.WriteLine("Press space bar to continue.");
                Console.ReadKey();
            }


        }
    }
}
