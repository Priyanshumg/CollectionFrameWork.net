using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    internal class AllDataStructureOperations
    {
        public static void LinkedList_Operations()
        {
            // Add Elements in LinkedList
            LinkedListOperations.AddElementsInLinkedList(Program.UsersDataArray);

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
            // Adds ALl Elements
            HashSetOperations.AddElementsInHashSet(Program.UsersDataArray);

            // Prints All Elements
            HashSetOperations.PrintHashSetElements();

            // Removes a Elements Provided in Array
            HashSetOperations.RemoveElementHashSet(Program.SampleArrayElements);

            // Remove Particular Element
            HashSetOperations.RemoveElementHashSet("Sunil");
        }

        public static void List_Operations()
        {
            // Add Elements to List
            ListOperation.AddElementInList(Program.UsersDataArray);

            // Display Capacity of List
            ListOperation.PrintListCapacity();

            // Display Count of total elements in the list
            ListOperation.PrintLengthList();
        }

        public static void Stack_Operations()
        {
            // Add Elements in a Stack
            StackOperations.AddElementsInStack(Program.UsersDataArray);

            // Display All Elements In Stack
            StackOperations.DisplayAllElementsInStack();

            // Check String Is in Stack Or Not
            StackOperations.CheckStringInStack("Priyanshu");

            // Check String In Stack Or Not
            StackOperations.CheckStringInStack("Gandhi");

            // Removes Last Elements from an array
            StackOperations.RemoveLastElementInStack();

            // Removes All Elements from an array
            StackOperations.RemoveAllElementsInStack();
        }
        public static void Queue_Operations()
        {
            // Adds Elements To the Queue
            QueueOperations.AddElementeInQueue(Program.UsersDataArray);

            // Displays All elements in a Queue
            QueueOperations.DisplayAllElementsInQueue();

            // Prints Total Elements in a Queue
            QueueOperations.TotalElementsInQueue();

            // Display First Element of a Queue
            QueueOperations.FirstElementInQueue();

            // Display and Remove First Element from the Queue
            QueueOperations.RemoveFirstElementInQueue();
        }
    }
}
