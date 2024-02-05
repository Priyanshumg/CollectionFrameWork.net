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
            // Adding Elements to HashSet
            HashSetOperations.AddElementsInHashSet(UsersDataArray);
            
            // Print All Elements of HashSet
            HashSetOperations.PrintHashSetElements();
            
            // Remove Elements from HashSet using Array
            HashSetOperations.RemoveElementHashSet(SampleArrayElements);
            
            // Remove Elements by passing String Value
            HashSetOperations.RemoveElementHashSet("Sunil");
        }
        static void Main(string[] args)
        {
            // Performing Linked List Operations
            LinkedList_Operations();

            // Performing Hash Set Operations
            HashSet_Operations();
            Console.ReadLine();
        }   
    }
}
