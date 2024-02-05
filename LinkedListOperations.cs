using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    internal class LinkedListOperations
    {
        // Create a new LinkedList
        public static LinkedList<string> myLinkedList = new LinkedList<string>();
        
        // Adds Element in Linked List
        public static void AddElementsInLinkedList(String[] ArrayUserData)
        {
            Console.WriteLine("Adding Elements in LinkedList");
            foreach (string item in ArrayUserData)
            {
                myLinkedList.AddLast(item);
            }
            Console.WriteLine("Added Elements SuccessFully");
            Console.WriteLine();
        }

        // Prints All Element in a Linked List
        public static void PrintLinkedList()
        {
            // Printing all elements in a linkedlist
            Console.Write("CurrentList { ");
            Thread.Sleep(1000);
            foreach (string str in myLinkedList)
            {
                Console.Write("{0}, ", str);
                Thread.Sleep(500);
            }
            Console.WriteLine("Null }");
            Console.WriteLine();
        }

        // Removes First Element of the LinkedList
        public static void RemoveFirstElement()
        {
            myLinkedList.RemoveFirst();
            Console.WriteLine("Removed First Element of a LinkedList");
            PrintLinkedList();
        }

        // Removes Last Element of the LinkedList
        public static void RemoveLastElement()
        {
            myLinkedList.RemoveLast();
            Console.WriteLine("Removed Last Element of a LinkedList");
            Console.WriteLine("Printing Current LinkedList of Elements:");
            PrintLinkedList();
        }

        // Removes element by the Key Value in a LinkedList
        public static void RemoveByValue(string nodeValue)
        {
            Console.WriteLine("Removing the Index value provided {0}", nodeValue);
            Console.WriteLine("Printing Current LinkedList of Elements:");
            myLinkedList.Remove(nodeValue);
            PrintLinkedList();
        }

        // Removes all the elements from the LinkedList
        public static void RemoveAllElementsLinkedList()
        {
            Console.WriteLine("Removing All Elements in a LinkedList");
            myLinkedList.Clear();
            Console.WriteLine("Removed All Elements from LinkedList");
            PrintLinkedList();
        }

    }
}
