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
        public static LinkedList<string> myLinkedList = new LinkedList<string>();

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

    }
}
