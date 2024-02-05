using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] UsersDataArray = { "Arun", "Garv", "Sunil", "Prince", "Aish" ,"Ankit", "Esha", "Namit", "Manikanta", "Dhanush", "Shovik", "Prakhar" };
            LinkedListOperations.AddElementsInLinkedList(UsersDataArray);
        }
    }
}
