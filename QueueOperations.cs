﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    class QueueOperations
    {
        public static Queue newQueue= new Queue();

        public static void AddElementeInQueue(string[] ArrayUserData)
        {
            Console.WriteLine("Adding Elements to the Queue");
            Thread.Sleep(1000);
            foreach (string elements in ArrayUserData)
            {
                newQueue.Enqueue(elements);
            }
            Thread.Sleep(1000);
            Console.WriteLine("Added Elements to the Queue Successfully");
            Console.WriteLine();
        }

        public static void DisplayAllElementsInQueue()
        {
            Console.WriteLine("Printing Elements in Queue");
            Console.Write("{ ");
            foreach (string elements in newQueue)
            {
                Console.Write($"{elements}, ");
            }
            Console.WriteLine("Null }");
            Console.WriteLine();
        }

        public static void FirstElementInQueue()
        {
            Console.WriteLine($"First Element in Queue {newQueue.Peek()}");
            Console.WriteLine();
        }

        public static void TotalElementsInQueue()
        {
            Console.WriteLine($"total Number Of Element in a Queue: {newQueue.Count}");
            Console.WriteLine();
        }

        public static void RemoveFirstElementInQueue()
        {
            Console.WriteLine($"Removing First Element from the Queue: {newQueue.Dequeue()}");
            Console.WriteLine("Printing new Queue");
            Console.WriteLine();
            DisplayAllElementsInQueue();
        }
    }
}
