using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    class ListOperation
    {
        // List from System.Collections.Generics
        public static List<string> newList = new List<string>();
        
        // Adds element to newList 
        public static void AddElementInList(String[] ArrayUserData)
        {
            Console.WriteLine("Adding Elements Passed in Array");
            Thread.Sleep(1000);
            foreach (string elements in ArrayUserData)
            {
                newList.Add(elements);
            }
            Console.WriteLine("Added Elements Successfully");
        }

        // Prints List Capacity
        public static void PrintListCapacity()
        {
            Console.WriteLine($"List Capacity = {newList.Capacity} Bytes");
        }

        // Prints Length of the List
        public static void PrintLengthList()
        {
            Console.WriteLine($"List Length = {newList.Count}");
        }
    }
}
