using System;

namespace Fullnamereversed
{
    class Program
    {
        static void Main(string[] args)
            
           

        {
            Console.WriteLine("Palun sisestada oma eesnimi");
            string userfirstname = Console.ReadLine();
            Console.ReadLine("Palun sisestada oma eesnimi");
            string userlastname = Console.ReadLine();

            for (int i = userlastname.Length - 1; i >= 0; i--)
            {
                Console.Write(userfirstname[i]);

            }



        }
    }
}
