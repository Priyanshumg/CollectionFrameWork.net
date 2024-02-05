using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    public class HashSetOperations
    {
        public static HashSet<string> newHashSet = new HashSet<string>();


        public static void AddElementsInHashSet(String[] ArrayUserData)
        {
            foreach (string element in ArrayUserData)
            {
                newHashSet.Add(element);
            }
        }
        public static void PrintHashSetElements()
        {
            Console.WriteLine("Printing Hash Set Elements");
            Thread.Sleep(1000);
            Console.Write("{ ");
            foreach (string element in newHashSet)
            {
                Thread.Sleep(1000);
                Console.Write(element + " , ");
            }
            Thread.Sleep(1000);
            Console.WriteLine(" Null}");
            Console.WriteLine();
        }

    }
}
