﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    internal class Program
    {
        public static String[] UsersDataArray = { "Arun", "Garv", "Sunil", "Prince", "Aish", "Ankit", "Esha", "Namit", "Manikanta", "Dhanush", "Shovik", "Prakhar" };

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
        static void Main(string[] args)
        {
            // Array For Inputs

            LinkedList_Operations();
            Console.ReadLine();
        }   
    }
}
