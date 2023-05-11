using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Cell
    {
        public string Value;
        public Cell Next;
        public Cell Prev;

        public void enqueue(Cell topSentinel, string data)
        {
            Cell cell = new Cell(); 
            cell.Value = data;
            cell.Next = topSentinel.Next;
            cell.Next.Prev = cell; 
            cell.Prev = topSentinel; 
            topSentinel.Next = cell;
        }

/*        public void dequeue(Cell topSentinel, string data)
        {
            Cell cell = topSentinel.Next; // Get the first cell in the list

            // Traverse the list to find the cell with the specified value
            while (cell != null && cell.Value != data)
            {
                cell = cell.Next;
            }

            if (cell == null)
            {
                // The specified value was not found in the list
                Console.WriteLine($"The value {data} was not found in the list.");
                return;
            }

            // Update the linked list to remove the cell with the specified value
            if (cell.Next != null)
            {
                cell.Next.Prev = cell.Prev;
            }
            cell.Prev.Next = cell.Next;
            cell = null; // Free the memory associated with the dequeued cell
        }*/

        public void dequeue()
        {
            if(this.Prev != null)
            {
                this.Prev.Prev.Next = this;
                this.Prev = this.Prev.Prev;
            }
        }



    }
}
