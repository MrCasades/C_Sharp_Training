using System;

namespace Gladiator_Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            float health1 = rd.Next(90, 120);
            int damage1 = rd.Next(5, 30);
            int armor1 = rd.Next(50, 85);

            float health2 = rd.Next(80, 160);
            int damage2 = rd.Next(5, 50);
            int armor2 = rd.Next(65, 100);

            int stepCount = 0;

            Console.WriteLine("Gladiator 1 has " + health1 + " health! His start damage " + damage1 + " and armor " + armor1);
            Console.WriteLine("Gladiator 2 has " + health2 + " health! His start damage " + damage2 + " and armor " + armor2);
            Console.WriteLine("******************************************************");

            while (health1 > 0 && health2 >0)
            {
                health1 -= Convert.ToSingle(rd.Next(0, damage2)) / 100 * armor1;
                health2 -= Convert.ToSingle(rd.Next(0, damage1)) / 100 * armor2;

                Console.WriteLine("Gladiator 1 " + health1);
                Console.WriteLine("Gladiator 2 " + health2);

                Console.WriteLine("************* STEP " + stepCount + " *************");

                stepCount++;
            }

            if ((health1 <= 0) && (health2 <=0))
            {
                Console.WriteLine("Both are dead!");
            }

            else if(health1 <= 0)
            {
                Console.WriteLine("Gladiator 1 is dead");
            }

            else if (health2 <= 0)
            {
                Console.WriteLine("Gladiator 2 is dead");
            }
        }
    }
}
