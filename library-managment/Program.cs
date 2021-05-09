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
                Console.WriteLine("\n\n 1 - What it is book, if i know index\n\n 2 - Find book if you know author\n\n 3 - View all books\n\n 4 - Exit");
                Console.WriteLine("\n\nEnter number from menu");

                switch (Convert.ToInt32 (Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int cols;

                        Console.WriteLine("Enter row number");
                        rows = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("Enter col number");
                        cols = Convert.ToInt32(Console.ReadLine()) - 1;


                        Console.WriteLine("\nIt is " + books[rows, cols]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFind = false;

                        Console.WriteLine("Enter name of author: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i,j].ToLower())
                                {
                                    Console.WriteLine("Adress of author " + author + " is " + (i + 1) + " | " + (j + 1));
                                    authorIsFind = true;
                                }
                            }                          
                        }

                        if (authorIsFind == false)
                        {
                            Console.WriteLine("Cannot find author");
                        }

                        break;
                    case 3://Вывод всех книг
                        Console.WriteLine("All authors");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.Write(books[i, j] + " | ");
                            }

                            //Console.WriteLine();
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }
                Console.WriteLine("\n\nPress any key to continue...");
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
