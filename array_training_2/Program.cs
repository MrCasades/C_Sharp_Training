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

            while(isOpen)
            {
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine("Table " + (i + 1) + " is free " + tables[i] + " seats");    
                }

                Console.WriteLine("\n******************************\n");
                Console.WriteLine("1 - book the table \n2 - Exit");
                Console.WriteLine("Enter command number");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                   
                    case 1:
                        int userTable, userPlace;
                        Console.Write("Witch table do you want to book? ");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;

                        if(userTable > tables.Length || userTable <= 0)
                        {
                            Console.Write("we don't have that many tables ");
                            break;
                        }

                        Console.Write("How much places do you want to book? ");
                        userPlace = Convert.ToInt32(Console.ReadLine());

                        if(tables[userTable]< userPlace || userPlace <= 0)
                        {
                            Console.Write("Not enough seats at the table. Try again!");
                            break;
                        }

                        tables[userTable] -= userPlace;
                        break;

                    case 2: isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
