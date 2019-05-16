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

            int i;
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            i = int.Parse(age);

            Console.WriteLine($"\n{age} huh? Interesting...");


            Console.WriteLine($"{name}, please enter your birth month as a number between 1-12");
            string month = Console.ReadLine();
            int monthValue = Int32.Parse(month);

            Console.WriteLine("\nGetting closer to your fortune...");

            Console.WriteLine("What is your favorite RYOGBIV color? If unsure type \"Help\".");
            string colorResponse = Console.ReadLine();
            if (colorResponse.ToLower().Equals("help")) {
                Console.WriteLine("ROYGBIV Colors are: Red, Yellow, Orange, Blue, Green, Indigo, and Violet."); //need a while loop back to original question.
            }

            Console.WriteLine("\nHow many siblings do you have?");
            string siblings = Console.ReadLine();
            int siblingValue = Int32.Parse(siblings);
            Console.WriteLine("\nThank you for answering my questions. Press enter for your fortune!");
            Console.ReadLine();


            string driveValue = "";
            if (i % 2 == 0)
            {
                driveValue = ("tomorrow");
            }
            else
            {
                driveValue = ("in 50 years");
            }



            string bankNumber = "";
            if ((monthValue == 1 || monthValue == 2 || monthValue == 3))
            {
                bankNumber = ("50,000 dollars");
            }
            else if ((monthValue == 4 || monthValue == 5 || monthValue == 6))
            {
                bankNumber = ("50,000 yen");
            }
            else if (monthValue == 7 || monthValue == 8 || monthValue == 9)
            {
                bankNumber = ("50,000 bird eggs");
            }
            else if (monthValue == 10 || monthValue == 11 || monthValue == 12)
            {
                bankNumber = ("50,000 pesos");
            }




            string retireLocation = "";
            if (colorResponse.ToLower().Equals("red"))
            {
                retireLocation = ("in Rome, Italy");
            }
            else if (colorResponse.ToLower().Equals("orange"))
            {
                retireLocation = ("in Moscow, Russia");
            }
            else if (colorResponse.ToLower().Equals("yellow"))
            {
                retireLocation = ("in a cave in Arizona");
            }
            else if (colorResponse.ToLower().Equals("green"))
            {
                retireLocation = ("on a personal island in the Carribean (make sure to bring the sunscreen!)");
            }
            else if (colorResponse.ToLower().Equals("blue"))
            {
                retireLocation = ("in a mansion in Greece");
            }
            else if (colorResponse.ToLower().Equals("indigo"))
            {
                retireLocation = ("in a jail in North Korea");
            }
            else if (colorResponse.ToLower().Equals("violet"))
            {
                retireLocation = ("inside the Sydney Opera House in Sydney, Australia");
            }


                string vacationHome = "";
            if (siblingValue == 0)
            {
                vacationHome = ("a penthouse suite in Paris, France");
            }
            else if (siblingValue == 1)
            {
                vacationHome = ("on a beach in Japan");
            }
            else if (siblingValue == 2)
            {
                vacationHome = ("near a wildlife safari in Africa");
            }
            else if (siblingValue == 3)
            {
                vacationHome = ("at Cinderella's castle at Disneyland");
            }
            else if (siblingValue == 4)
            {
                vacationHome = ("in a cornfield in Montana");
            }
            else if (siblingValue > 4)
            {
                vacationHome = ("in a tree on public square in Cleveland, Ohio");
            }




            Console.WriteLine($"{name} {lastName}, you will retire {driveValue} {retireLocation}, with {bankNumber} in your bank account, and a vacation home located {vacationHome}. \nThank you for playing!");
            Console.ReadLine();
        }
    }
}
