﻿using System;
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
            // Adds Elements to Hash Set
            HashSetOperations.AddElementsInHashSet(UsersDataArray);
            
            // Prints Hash Set Elements
            HashSetOperations.PrintHashSetElements();
            
            // Remove Element array from Hash Set
            HashSetOperations.RemoveElementHashSet(SampleArrayElements);
            
            // Removes Element Individual element from an Hash Set
            HashSetOperations.RemoveElementHashSet("Sunil");
        }

        public static void List_Operations()
        {
            // Add Elements to List
            ListOperation.AddElementInList(UsersDataArray);
            
            // Display Capacity of List
            ListOperation.PrintListCapacity();

            // Display Count of total elements in the list
            ListOperation.PrintLengthList();
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
