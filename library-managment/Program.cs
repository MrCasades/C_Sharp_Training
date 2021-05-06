using System;

namespace library_managment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            string[,] books = { {"Pushkin", "Lermontov", "Gluhovsky" }, 
                                {"Stiven King", "Bram Stocker", "Govard Lavkraft" }, 
                                {"Dontsova", "Karr", "Prokopenko" } };

            while(isOpen)
            {
                Console.WriteLine("Library");
                Console.WriteLine("\n1 - What it is book, if i know index\n\n 2 - Find book if you know author\n\n 3 - View all books\n\n 4 - Exit");
                Console.WriteLine("Enter number from menu");

                switch (Convert.ToInt32 (Console.ReadLine()))
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine("All authors");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.Write(books[i, j] + " | ");
                            }

                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            for (int i = 0; i < books.GetLength(0); i++)
            {
                for(int j = 0; j < books.GetLength(1); j++)
                {
                    Console.Write(books[i, j] + " | ");
                }

                Console.WriteLine();
            }
        }
    }
}
