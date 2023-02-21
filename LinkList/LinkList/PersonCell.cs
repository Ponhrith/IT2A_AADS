using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkListCLI
{
    internal class PersonCell
    {
        public string Name;
        public PersonCell Next; //Next contains the address of the PersonCell obj

        public PersonCell() { }

        public PersonCell(string name, PersonCell next)
        {
            Name = name;
            Next = next;
        }

        public void InsertAfter(string newName)
        { //newCell is a new node
            PersonCell newCell = new PersonCell();
            newCell.Name = newName;
            newCell.Next = this.Next;
            this.Next = newCell;
        }

        public PersonCell FindCell(string name)
        {
            for (PersonCell cell = this; ; cell = cell.Next)
            {
                if (cell == null) return null;
                if (cell.Name == name) return cell;
            }
        }

        public void InsertAfter(string afterName, string newName)
        {
            PersonCell afterCell = FindCell(afterName);
            if (afterCell == null)
            {
                throw new KeyNotFoundException("Item " + afterName + "not found in list");
            }
            //Insert a new cell with the new name after the one we found 
            afterCell.InsertAfter(newName);
        }
    }
}
