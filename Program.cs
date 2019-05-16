using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}");

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"\nThank you {name} {lastName}");

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int ageValue = Int32.Parse(age);
            int retireAge = 0;

            Console.WriteLine($"\n{age} huh? Interesting...");


            Console.WriteLine($"{name}, please enter your birth month as a number between 1-12");
            string month = Console.ReadLine();
            Console.WriteLine("\nGetting closer to your fortune...");

            Console.WriteLine("What is your favorite RYOGBIV color? If unsure type \"Help\".");
            string colorResponse = Console.ReadLine();
            if (colorResponse.ToLower().Equals("help")) {
                Console.WriteLine("ROYGBIV Colors are: Red, Yellow, Orange, Blue, Green, Indigo, and Violet.");
            }

            Console.WriteLine("\nHow many siblings do you have?");
            string siblingValue = Console.ReadLine();
            Console.WriteLine("\nThank you for answering my questions. Press enter for your fortune!");


            string driveValue = "";
            if (ageValue >= 72)
            {
                driveValue = ("Maserati");
            }
            else if (ageValue >= 0 || ageValue < 25)
            {
                Console.WriteLine("Unicycle");
            }
            else if (ageValue < 45 || ageValue >= 25) { Console.WriteLine("Private Jet Plane"); }
            else if (ageValue < 72 || ageValue >= 45) { Console.WriteLine("Zip Line"); };

            string retireLocation = "";
            if (colorResponse.ToLower().Equals("red"))
            {
                retireLocation = ("in Rome, Italy!");
            }
            else if (colorResponse.ToLower().Equals("orange"))
            {
                retireLocation = ("in Moscow, Russia.");
            }
            else if (colorResponse.ToLower().Equals("yellow"))
            {
                retireLocation = ("in a cave in Arizona.");
            }
            else if (colorResponse.ToLower().Equals("green"))
            {
                retireLocation = ("on a personal island in the Carribean! (Make sure to bring the sunscreen!)");
            }
            else if (colorResponse.ToLower().Equals("blue"))
            {
                retireLocation = ("in a mansion in Greece!");
            }


            Console.WriteLine($"{name} {lastName}, You will retire {retireLocation}, driving a {driveValue}, with . \nThank you for playing!");
            Console.ReadLine();
        }
    }
}
