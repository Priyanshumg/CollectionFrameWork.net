using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    internal class Program
    {
        // Array For Inputs
        public static String[] UsersDataArray = { "Arun", "Garv", "Sunil", "Roshan","Prince", "Aish", "Ankit", "Esha", "Namit", "Manikanta", "Dhanush", "Shovik", "Prakhar" };
        public static String[] SampleArrayElements = { "Garv", "Roshan" };
        private static void LinkedList_Operations()
        {
            // Add Elements in LinkedList
            LinkedListOperations.AddElementsInLinkedList(UsersDataArray);

            // Print All Elements in LinkedList
            LinkedListOperations.PrintLinkedList();

            // Remove First Element In LinkedList
            LinkedListOperations.RemoveFirstElement();

            // Remove Last Element in LinkedList
            LinkedListOperations.RemoveLastElement();

            // Remove Element By Passing Value
            LinkedListOperations.RemoveByValue("Aish");

            // Removing All the elements in LinkedList
            LinkedListOperations.RemoveAllElementsLinkedList();
        }

        public static void HashSet_Operations()
        {
            HashSetOperations.AddElementsInHashSet(UsersDataArray);
            HashSetOperations.PrintHashSetElements();
            HashSetOperations.RemoveElementHashSet(SampleArrayElements);
            HashSetOperations.RemoveElementHashSet("Sunil");
        }

        static void List_Operations()
        {

        }
        static void Main(string[] args)
        {
            LinkedList_Operations();
            HashSet_Operations();
            List_Operations();
            Console.ReadLine();
        }   
    }
}
