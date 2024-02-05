using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWorks
{
    public class HashSetOperations
    {
        static HashSet<string> newHashSet = new HashSet<string>();
        public static void AddElementsInHashSet(String[] ArrayUserData)
        {
            foreach (string element in ArrayUserData)
            {
                newHashSet.Add(element);
            }
        }
    }
}
