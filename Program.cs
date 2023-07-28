
using System;

namespace Yield
{
    internal class Program
    {
        static void Main()
        {
            foreach (string element in UseerCollection.Power()) 
            {
                Console.WriteLine(element) ;
            }
            
            foreach (string element in UseerCollection.NoPower())
            {
                Console.WriteLine(element);
            }
            
            foreach (int element in UseerCollection.InragerIenum())
            {
                Console.WriteLine(element);
            }

            foreach (object element in UseerCollection.Objejcts())
            {
                Console.WriteLine(element);
            }


            Console.ReadLine();
        }
    }
}
