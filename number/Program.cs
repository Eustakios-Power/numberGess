using System;

namespace number
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Gess the number between 0 and 100");
            int input = Int32.Parse(Console.ReadLine());
            int numUsed = randomNumber();
            int tries = 1;
            while (input != numUsed)
            {
                tries++;

                if(input > numUsed)
                {
                    Console.WriteLine("The number to gess is smaller");
                }
                else
                {
                    Console.WriteLine("The number to gess is bigger");
                }
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Yep, {numUsed} is the number. It took you {tries} tries.");
        }

        static int randomNumber()
        {
            //create random
            int rndNumber = rnd.Next(0, 101);
            return rndNumber;
        }
    }
}
