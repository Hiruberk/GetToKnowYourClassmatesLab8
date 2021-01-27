using System;
using System.Linq;
using System.Collections.Generic;

namespace Get_To_Know_Your_Classmates_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[] { "Ramon", "Antonio", "Joshua", "Nick", "Jeremiah", "Wendi", "Juliana", "Nathaniel", "Tommy", "Grace", "Jeffrey", "Josh", "Stephen" };
            string[] lastNames = new string[] { "Guarnes", "Manzari", "Carolin", "D'Oria", "Wyeth", "Magee", "Juliana", "Davis", "Waalkes", "Seymore", "Wohlfield", "Gallentine", "Jedlicki" };
            string[] hometown = new string[] { "Tigard, OR", "Beverly Hills, MI", "Novi, MI", "Canton, MI", "Crystal, MI", "Detroit, MI", "Denver, CO", "Berkley, MI", "Raleigh, NC", "Mesa, AZ", "Detroit, MI", "Baldwin, MI", "The Moon" };
            string[] favFood = new string[] { "Burgers", "Focaccia Barese", "Nalesniki", "Tacos", "Burgers", "Salami", "Tacos", "Steak", "Chicken Curry", "Sweet Potato Fries", "Steak", "Falafel", "Mooncakes" };
            //count is 13 on all 4

            string home = "hometown";
            string food = "favorite food";

            Console.WriteLine("Welcome to Daytime Jan 2021 C# Class. Which student would you like to learn more about? (enter a number 1-13):");

            string input = "";

            while (true)
            {

                try
                {
                    input = Console.ReadLine();
                    int entry = GetIndex(input);
                    int index = entry - 1;

                    Console.WriteLine($"Student {entry} is {firstNames[index]} {lastNames[index]}. What would you like to know about {firstNames[index]}? (enter \"hometown\" or \"favorite food\")");

                    while(true)
                    {
                        string option = Console.ReadLine();
                        if (home.Contains(option))
                        {
                            Console.WriteLine($"{firstNames[index]} is from {hometown[index]}.");
                            break;
                        }
                        else if (food.Contains(option))
                        {
                           
                            Console.WriteLine($"{firstNames[index]} favorite food is {favFood[index]}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter a \"hometown\" or \"favorite food\")");
                            
                        }
                    } 
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Who is that? They must not be in our class. Try again. (enter a number 1-13)");
                    continue;
                }


                Console.WriteLine("would you like to know more? (y/n): ");

                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }

                Console.WriteLine("Which student would you like to learn more about ? (enter a number 1 - 13):");
            }

            Console.WriteLine("Thanks for stopping by!");
        }

        public static int GetIndex(string message)
        {
            while (true)
            {
                string input = message;
                try
                {
                    int numberInput = int.Parse(input);
                    return numberInput;
                    

                }
                catch (FormatException)
                {
                    Console.WriteLine($"{input} was not a number at all. Please try again. (enter a number 1 - 13)");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out int numberInput))
                    {
                        return numberInput;
                    }
                    continue;
                    
                }
                
            }
        }
    }
}

