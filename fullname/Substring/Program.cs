using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World";
            string partToLookFor = "hello";
            
            bool isThere;

            isThere = helloworld.ToLower().Contains(partToLookFor);

            if(isThere)
            {
                Console.ReadLine($"leidsin {partToLookFor} üles");

            }
            else
            {
                Console.ReadLine($"ei leidnud {partToLookFor}");
            }
                

        }
    }
}
