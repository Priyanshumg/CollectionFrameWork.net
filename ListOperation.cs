using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    class ListOperation
    {
        public static List<string> newList = new List<string>();
        public static void AddElementInList(String[] ArrayUserData)
        {
            Console.WriteLine("Adding Elements Passed in Array");
            Thread.Sleep(1000);
            foreach (string elements in ArrayUserData)
            {
                newList.Add(elements);
            }
            Console.WriteLine("Added Elements Successfully");
        }

    }
}
