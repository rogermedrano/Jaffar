using System;

namespace VariableEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string petName = "Jaffar";
            string petType = "Bearded Dragon";
            int timeOwned = 2;
            char letter = 'a';
            bool yes = true;
            double price = 200.00;
            Console.WriteLine($"My pet's name is {petName}, and he is a {petType}.  My son had him for {timeOwned} so far.  He better take care of {petName} because that {petType} cost me {price}!");


        }
    }
}
