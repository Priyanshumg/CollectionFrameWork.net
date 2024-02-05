using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    class StackOperations
    {
        public static Stack<string> newStack = new Stack<string>();

        public static void AddElementsInStack(string[] ArrayUserData)
        {
            foreach (string elements in ArrayUserData)
            {
                newStack.Push(elements);
            }
        }
    }
}
