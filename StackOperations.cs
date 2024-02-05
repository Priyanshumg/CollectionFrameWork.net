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
        }

        public static void RemoveAllElementsInStack()
        {
            // Removes all the element inside a stack(Returns Empty stack)
            Console.WriteLine("Removing Elements in stack");
            Thread.Sleep(2000);
            newStack.Clear();
            Console.WriteLine("Removed All Elements from the stack successfully");
        }
    }
}
