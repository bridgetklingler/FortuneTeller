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
            int ageValue = Convert.ToInt32(age);

            Console.WriteLine($"\n{age} huh? Interesting...");
            
            
            Console.WriteLine($"\n{name}, please enter your birth month as a number between 1-12");
            string month = Console.ReadLine();
            Console.WriteLine("Getting closer to your fortune...");

            Console.WriteLine("\nWhat is your favorite RYOGBIV color? If unsure type \"Help\".");
            string colorResponse = Console.ReadLine();
            if (colorResponse.ToLower().Equals("help")){
                Console.WriteLine("ROYGBIV Colors are: Red, Yellow, Orange, Blue, Green, Indigo, and Violet.");
            }
            Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");
            string siblingValue = Console.ReadLine();
            Console.WriteLine("Thank you for answering my questions. Press enter for your fortune!");
 
            if (ageValue >= 72)
            {
                Console.WriteLine("You're an old fart!");
            }
            else if (ageValue >= 0 || ageValue < 25)
            {
                Console.WriteLine("You have your whole life ahead of you!");
            }
            else if (ageValue < 45 || ageValue >= 25) { Console.WriteLine("You're so young!"); }
            else if (ageValue < 72 || ageValue >= 45) { Console.WriteLine("You're almost ready to retire!"); };
            Console.ReadLine();

            if (colorResponse.ToLower().Equals("red"))
            {
                Console.WriteLine("You'll retire in Rome, Italy!");
            }
            else if (colorResponse.ToLower().Equals("orange"))
            {
                Console.WriteLine("You'll retire in Moscow, Russia.");
            }
            else if (colorResponse.ToLower().Equals("yellow"))
            {
                Console.WriteLine("You'll retire in a cave in Arizona.");
            }
            else if (colorResponse.ToLower().Equals("green"))
            {
                Console.WriteLine("You'll retire on a personal island in the Carribean! (Make sure to bring the sunscreen!)");
            }
            else if (colorResponse.ToLower().Equals("blue"))
            {
                Console.WriteLine("You're going to retire in a mansion in Greece!");
            }
            Console.ReadLine();
        }
    }
}
