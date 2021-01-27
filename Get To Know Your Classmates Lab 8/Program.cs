using System;
using System.Linq;
using System.Collections.Generic;

namespace Get_To_Know_Your_Classmates_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>() { "Ramon", "Antonio", "Joshua", "Nick", "Jeremiah", "Wendi", "Juliana", "Nathaniel", "Tommy", "Grace", "Jeffrey", "Josh", "Stephen" };
            List<string> lastNames = new List<string>() { "Guarnes", "Manzari", "Carolin", "D'Oria", "Wyeth", "Magee", "Juliana", "Davis", "Waalkes", "Seymore", "Wohlfield", "Gallentine", "Jedlicki" };
            List<string> hometown = new List<string>() { "Tigard, OR", "Beverly Hills, MI", "Novi, MI", "Canton, MI", "Crystal, MI", "Detroit, MI", "Denver, CO", "Berkley, MI", "Raleigh, NC", "Mesa, AZ", "Detroit, MI", "Baldwin, MI", "The Moon" };
            List<string> favFood = new List<string>() { "Burgers", "Focaccia Barese", "Nalesniki", "Tacos", "Burgers", "Salami", "Tacos", "Steak", "Chicken Curry", "Sweet Potato Fries", "Steak", "Falafel", "Mooncakes" };
            //count is 13 on all 4

            Console.WriteLine("Welcome to Daytime Jan 2021 C# Class. Which student would you like to learn more about? (enter a number 1-14):");
            

            while (true)
            {
           
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    int index = input + 1;

                    Console.WriteLine($"Student {index} is {firstNames[index]} {lastNames[index]}. What would you like to know about {firstNames[index]}? (enter hometown OR favorite food)");

                    do
                    {
                        if (Console.ReadLine() != "hometown" || Console.ReadLine() != "favorite food")
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter a \"hometown\" OR \"favorite food\")");
                        }
                        else if (Console.ReadLine() == "hometown")
                        {
                            Console.WriteLine($"{firstNames[index]} is from {hometown[index]}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{firstNames[index]} favorite food is {favFood[index]}.");
                            break;
                        }
                    } while (true);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Who is that? They must not be in our class. Try again. (enter a number 1-14)");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{Console.ReadLine()} was not a number at all. Please try again. (enter a \"hometown\" OR \"favorite food\")");
                }

                Console.WriteLine("would you like to know more? (y/n): ");

                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }

                Console.WriteLine("Which student would you like to learn more about ? (enter a number 1 - 14):");
            }

            Console.WriteLine("Thanks for stopping by!");
        }
    }
}
