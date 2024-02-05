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

        public static void RemoveElementHashSet(string[] RemoveElementsInArray)
        {
            foreach (string ArrayElement in RemoveElementsInArray)
            {
                newHashSet.Remove(ArrayElement);
            }
            Console.Write("Removed These Elements { ");
            foreach (string Element in RemoveElementsInArray)
            {
                Thread.Sleep(1000);
                Console.Write(Element + ", ");
            }
            Console.WriteLine(" Null };");
            Console.WriteLine("Printing Updated Array");
            PrintHashSetElements();
            Console.WriteLine();
        }
        public static void RemoveElementHashSet(string SingleElementToRemove)
        {
            Console.WriteLine("Removing " + SingleElementToRemove + " from the HashSet");
            newHashSet.Remove(SingleElementToRemove);
            PrintHashSetElements();
            Console.WriteLine();
        }

    }
}
