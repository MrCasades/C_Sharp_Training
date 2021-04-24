using System;

namespace CycleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            int count = 0;
            while (age > 0)
            {
                Console.WriteLine("Happy!");
                count++;

                if (count == 11) break;
            }
        }
    }
}
