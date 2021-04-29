using System;

namespace array_training_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * сумма всех э-тов
             * 
             * int[] arr1 = { 1, 3, 5, 6, 7, 0 };

             int sum = 0;

             for (int i = 0; i < arr1.Length; i++)
             {
                 Console.WriteLine(arr1[i]);

                 sum += arr1[i];
             }

             Console.WriteLine("==========> " + sum);*/

            /*
             * Максимальное значение
             * 
             * int[] arr1 = { 1, 3, 5, 6, 7, 0 };

            int maxEl = int.MinValue;//присваиваем минимальное значение типа

            for (int i = 0; i < arr1.Length; i++)
            {
                if (maxEl < arr1[i])
                {
                    maxEl = arr1[i];
                }
            }

            Console.WriteLine(maxEl);*/

            //Система брони столов

            bool isOpen = true;

            int[] tables = { 7, 5, 9, 10, 8, 7, 3 };

            while(true)
            {
                Console.WriteLine("1 - view tables list \n2 - book the table \n3 - Exit");
                Console.WriteLine("Enter command number");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        for (int i = 0; i < tables.Length; i++)
                        {
                            Console.WriteLine("Table " + (i + 1) + " is free " + tables[i] + " seats");
                        }
                        break;

                    case 2:
                        int userTable, userPlace;
                        Console.Write("Witch table do you want to book? ");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("How much places do you want to book? ");
                        userPlace = Convert.ToInt32(Console.ReadLine());

                        tables[userTable] -= userPlace;
                        break;

                    case 3: isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
