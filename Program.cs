using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    internal class Program
    {
        // Array For Inputs
        static public String[] UsersDataArray = { "Arun", "Garv", "Sunil", "Roshan","Prince", "Aish", "Ankit", "Esha", "Namit", "Manikanta", "Dhanush", "Shovik", "Prakhar" };
        static public String[] SampleArrayElements = { "Garv", "Roshan" };
        static void Main(string[] args)
        {
            // Performing Linked List Operations
            AllDataStructureOperations.LinkedList_Operations();

            // Performing Hash Set Operations
            AllDataStructureOperations.HashSet_Operations();
            
            // Performing List Operations 
            AllDataStructureOperations.List_Operations();

            // Stack Operations
            AllDataStructureOperations.Stack_Operations();

            //Queue Operations
            AllDataStructureOperations.Queue_Operations();
            
            Console.ReadLine();
        }   
    }
}
