using System;

namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, lower, larger;
            int tryCount = 5;
            Random rd = new Random();

            int userInput;

            number = rd.Next(0, 100);

            lower = rd.Next(number - 10, number);
            larger = rd.Next(number+1, number + 10);

            Console.WriteLine("We guessed number from 0 to 100. It is more " + lower + " and  less " + larger);
            Console.WriteLine("What is the number?");

            while(tryCount-- > 0)
            {
                Console.WriteLine("It is...");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("It is right! You win!");
                    break;
                }

                else
                {
                    Console.WriteLine("This is not true... Try again!");
                }
            }

            if (tryCount < 0)
            {
                Console.WriteLine("You lose! It was number " + number);
            }
        }
    }
}
