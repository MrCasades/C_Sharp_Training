using System;

namespace ArrayTraining_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int [10];
            int count = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                count++;
                arr1[i] = count;
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
