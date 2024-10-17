//Create a project to demonstrate the working of command line arguments for constant and read only using command prompt.
using System;
namespace LAB
{
    class Program1
    {
        public static void Main(string [] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadKey();
        }

        
    }
}