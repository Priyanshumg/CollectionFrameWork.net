using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    class QueueOperations
    {
        public static Queue newQueue= new Queue();

        static void AddElementeInQueue(string[] ArrayUserData)
        {
            Console.WriteLine("Adding Elements to the Queue");
            Console.Write("{ ");
            foreach (string elements in ArrayUserData)
            {
                newQueue.Enqueue(elements + ", ");
            }
            Console.WriteLine(", Null }");
            Console.WriteLine("Added Elements to the Queue Successfully");
        }
    }
}
