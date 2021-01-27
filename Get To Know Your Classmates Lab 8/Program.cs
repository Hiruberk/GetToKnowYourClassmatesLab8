using System;
using System.Linq;
using System.Collections.Generic;

namespace Get_To_Know_Your_Classmates_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {   //Declaring all the arrays that are of equal length, so I can use the same index to reference to like information
            string[] firstNames = new string[] { "Ramon", "Antonio", "Joshua", "Nick", "Jeremiah", "Wendi", "Juliana", "Nathaniel", "Tommy", "Grace", "Jeffrey", "Josh", "Stephen" };
            string[] lastNames = new string[] { "Guarnes", "Manzari", "Carolin", "D'Oria", "Wyeth", "Magee", "Juliana", "Davis", "Waalkes", "Seymore", "Wohlfield", "Gallentine", "Jedlicki" };
            string[] hometown = new string[] { "Tigard, OR", "Beverly Hills, MI", "Novi, MI", "Canton, MI", "Crystal, MI", "Detroit, MI", "Denver, CO", "Berkley, MI", "Raleigh, NC", "Mesa, AZ", "Detroit, MI", "Baldwin, MI", "The Moon" };
            string[] favFood = new string[] { "Burgers", "Focaccia Barese", "Nalesniki", "Tacos", "Burgers", "Salami", "Tacos", "Steak", "Chicken Curry", "Sweet Potato Fries", "Steak", "Falafel", "Mooncakes" };
            //count is 13 on all 4

            //For readaiblity in the if statement below
            string home = "hometown";
            string food = "favorite food";
            
            Console.WriteLine("Welcome to Daytime Jan 2021 C# Class. Which student would you like to learn more about? (enter a number 1-13):\n");

            while (true)
            {

                try
                {
                    string input = Console.ReadLine();//Takes an index/student to look up
                    int entry = GetIndex(input);
                    int index = entry - 1;// This is to avoid calling a Student 0 allows it to be more user friendly

                    Console.WriteLine($"Student {entry} is {firstNames[index]} {lastNames[index]}. What would you like to know about {firstNames[index]}? (enter \"hometown\" or \"favorite food\"\n)");

                    while(true)
                    {
                        string option = Console.ReadLine();//Takes which information they woulkd like to learn
                        if (home.Contains(option))//The user gave hometown
                        {
                            Console.WriteLine($"{firstNames[index]} is from {hometown[index]}.\n");
                            break;
                        }
                        else if (food.Contains(option))//The user gave favorite food
                        {
                           
                            Console.WriteLine($"{firstNames[index]} favorite food is {favFood[index]}.\n");
                            break;
                        }
                        else//The user did not listen and didn't give either of the specified choices
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter a \"hometown\" or \"favorite food\")\n");
                            
                        }
                    } 
                }
                catch (IndexOutOfRangeException)//Cannot reference an index that is not in the array asks the user to try one in the specified range.
                {
                    Console.WriteLine("Who is that? They must not be in our class. Try again. (enter a number 1-13)\n");
                    continue;
                }


                Console.WriteLine("would you like to know more? (y/n): \n");//Prompts user to break loop or not

                if (Console.ReadLine().ToLower() == "n")
                {
                    break;//ends the program
                }

                Console.WriteLine("Which student would you like to learn more about ? (enter a number 1 - 13):\n");//Prompts user to look up future students
            }

            Console.WriteLine("Thanks for stopping by!\n");
        }

        /// <summary>
        /// Takes in the user entry to verify an index before returning one. It will throw an exception everytime
        /// the input cannot be converted to an integer.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns an integer if it can not will throw an exception and ask for another input.</returns>
        public static int GetIndex(string message)
        {
            while (true)
            {
                string input = message;
                try
                {
                    int numberInput = int.Parse(input);
                    return numberInput;//If user inputs a valid value will return without throwing an exception
                    

                }
                catch (FormatException) //This will throw when Console.ReadLine is any value that cannot be converted to an integer, such as "dog"
                {
                    Console.WriteLine($"{input} was not a number at all. Please try again. (enter a number 1 - 13)");
                    input = Console.ReadLine();
                    if (Int32.TryParse(input, out int numberInput))//When a good value has been entered will return the number and break the cycle
                    {
                        return numberInput;
                    }
                    continue;
                    
                }
                
            }
        }
    }
}

