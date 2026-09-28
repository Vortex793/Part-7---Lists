using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            while (!end)
            {
                Console.WriteLine("Which part of the program do you want to run?");
                Console.WriteLine("1 - Part 1: Integers");
                Console.WriteLine("2 - Part 2: Strings");
                Console.WriteLine("q - Quit");
                Console.Write(":");
                string choice = Console.ReadLine().ToLower();

                if (choice == "1")
                {
                    int removeNum, addNum, countNum;

                    Random generator = new Random();
                    List<int> numbers = new List<int>();


                    for (int i = 0; i <25; i++)
                    {
                        numbers.Add(generator.Next(10, 21));
                    }

                    bool part1end = false;

                    while (!part1end)
                    {
                        Console.Clear();
                        Console.WriteLine("Here is the list of numbers");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i]);

                            if (i < numbers.Count - 1)
                            {
                                Console.Write(", ");

                            }
                        }

                        Console.WriteLine("What would you like to do with this list (pick between 1-10)");
                        Console.WriteLine("1 - Sort the list");
                        Console.WriteLine("2 - Make a new list of random numbers");
                        Console.WriteLine("3 - Remove a number");
                        Console.WriteLine("4 - Add a number");
                        Console.WriteLine("5 - Count occurrences of a number");
                        Console.WriteLine("6 - Print largest number");
                        Console.WriteLine("7 - Print smallest number");
                        Console.WriteLine("8 - Print sum and average");
                        Console.WriteLine("9 - Print most frequent value");
                        Console.WriteLine("10 - Quit");
                        Console.Write(":");
                        string part1choice = Console.ReadLine();

                        //Sort the list
                        if (part1choice == "1")
                        {
                            numbers.Sort();
                        }
                        //Make a new list
                        else if (part1choice == "2")
                        {
                            numbers.Clear();

                            for (int i = 0; i < 25; i++)
                            {
                                numbers.Add(generator.Next(10, 21));
                            }
                        }
                        //Remove a number
                        else if (part1choice == "3")
                        {
                            Console.Write("Enter a number to remove: ");

                            while (!int.TryParse(Console.ReadLine(), out removeNum) && !numbers.Contains(removeNum))
                            {
                                Console.WriteLine("This is invalid please try again.");
                            }
                            while (numbers.Contains(removeNum))
                            {
                                numbers.Remove(removeNum);
                            }
                        }
                        else if (part1choice == "4")
                        {
                            Console.Write("Enter a number to add to the list: ");
                            while (!int.TryParse(Console.ReadLine(), out addNum))
                            {
                                Console.WriteLine("The value is invalid please try again");
                            }

                            numbers.Add(addNum);
                        }
                        //Count how many numbers
                        else if (part1choice == "5")
                        {
                            Console.Write("Enter a number to count: ");

                            while (!int.TryParse(Console.ReadLine(), out addNum))
                            {
                                Console.WriteLine("The value is invalid. Please try again.");
                                Console.Write("Enter a number to count: ");
                            }

                            int count = 0;

                            foreach (int number in numbers)
                            {
                                if (number == addNum)
                                {
                                    count++;
                                }
                            }

                            Console.WriteLine($"{addNum} appears {count} time(s)");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();

                        }
                        else if (part1choice == "6")
                        {
                            Console.WriteLine($"The largest number is {numbers.Max()}");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                        }
                        else if (part1choice == "7")
                        {

                        }
                        else if (part1choice == "8")
                        {

                        }
                        else if (part1choice == "9")
                        {

                        }
                        else if (part1choice == "10")
                        {
                            end = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                            Console.ReadKey();
                        }
                    }
                }

                if (choice == "2")
                {

                }

                if (choice == "q")
                {

                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
