using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    class StackOperations
    {
        public static Stack<string> newStack = new Stack<string>();

        public static void AddElementsInStack(string[] ArrayUserData)
        {
            Console.WriteLine("Adding Elements to the stack");
            Thread.Sleep(500);
            foreach (string elements in ArrayUserData)
            {
                newStack.Push(elements);
            }
            Console.WriteLine("Added Elements to stack Successfully");
            Console.WriteLine();
        }

        public static void RemoveAllElementsInStack()
        {
            // Removes all the element inside a stack(Returns Empty stack)
            Console.WriteLine("Removing Elements in stack");
            Thread.Sleep(2000);
            newStack.Clear();
            Console.WriteLine("Removed All Elements from the stack successfully");
            Console.WriteLine();
        }

        public static void CheckStringInStack(string UserString)
        {
            Console.WriteLine($"Checking if the {UserString} is Present inside stack or not");
            if (newStack.Contains(UserString))
            {
                Console.WriteLine("Yes This string is Present");
            }
            else
            {
                Console.WriteLine("We Dont have that element present in the list, Please check the Case Sensitivity of the string");
            }

            Console.WriteLine();
        }

        public static void RemoveLastElementInStack()
        {
            Console.WriteLine("Removing Last element from the Stack");
            newStack.Pop();
            Console.WriteLine("Removed Last Element SuccessFullt");
        }
    }
}
