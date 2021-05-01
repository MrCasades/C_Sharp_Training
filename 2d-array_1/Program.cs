using System;

namespace _2d_array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { {55,55,74 },
                           {69,98,77 },
                           {66,44,88 } };

            for (int i =0; i< arr.GetLength(0); i++)//Длина измерения массива
            {
                for (int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
