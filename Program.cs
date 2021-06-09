using System;
using System.Runtime.CompilerServices;

namespace QuikGamingThingy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this random game that i was asked to make! Please write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Oh so your name is " + name);

            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            int trys = 0;

            Boolean guessing = true;
            
            while (guessing)
            {
                Console.WriteLine("Guess the number: ");
                Console.WriteLine(randomNumber);
                
                int userNum;
                userNum = int.Parse(Console.ReadLine());
                
                if (userNum == randomNumber)
                {
                    Console.WriteLine("Well done you guessed the random number correctly!");
                    guessing = false;
                }

                if (userNum != randomNumber && userNum > randomNumber) //This checks if the number is too high and if the usernum is not equal too the random number
                {
                    Console.WriteLine("Sorry you guess the number too high, try again! \nWrite Quit if you want to exit the program or write Enter if you want to continue: ");
                    string choice = Console.ReadLine();
                    
                    trys += 1;
                    if (choice == "Enter")
                    {
                        Console.WriteLine("");
                    }
                    
                    else if (choice == "Quit" || choice == "quit")
                    {
                        System.Environment.Exit(0);
                    }
                    
                    else if (trys == 10)
                    {
                        Console.WriteLine("You have run out of trys!");
                    }
                }

                if (userNum != randomNumber && userNum < randomNumber)
                {
                    Console.WriteLine("Sorry you guessed the number to low, try again! \nWrite Quit if you want to exit the program or write Enter if you want to continue:");
                    string choice = Console.ReadLine();
                    
                    trys += 1;
                    if (choice == "Enter")
                    {
                        Console.WriteLine("");
                    }
                    
                    else if (choice == "Quit" || choice == "quit")
                    {
                        System.Environment.Exit(0);
                    }
                    
                    else if (trys == 10)
                    {
                        Console.WriteLine("You have run out of trys");
                        System.Environment.Exit(0);
                    }
                }
            }
        }

        static void HotOrCold()
        {
            
        }
    }
}