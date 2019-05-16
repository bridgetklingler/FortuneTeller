using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadLine();
               
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Thank you {name} {lastName}");
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int ageValue = Convert.ToInt32(age);

            Console.WriteLine($"{age} huh? Interesting...");
            
            
            Console.WriteLine($"{name}, please enter your birth month as a number between 1-12");
            string month = Console.ReadLine();
            Console.WriteLine("Getting closer to your fortune...");
            Console.ReadLine();

            Console.WriteLine("What is your favorite RYOGBIV color? If unsure type \"Help\".");
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

        }
    }
}
