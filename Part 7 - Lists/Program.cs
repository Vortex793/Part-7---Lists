using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7___Lists
{
    internal class Program
    {
        //CURTIS APFELBECK
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
                
                //Numbers list
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
                        Console.WriteLine("Here is the list of numbers: ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i]);


                            if (i < numbers.Count - 1)
                            {
                                Console.Write(", ");

                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
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

                            while (!int.TryParse(Console.ReadLine(), out removeNum) || !numbers.Contains(removeNum))
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
                        //Largest number
                        else if (part1choice == "6")
                        {
                            Console.WriteLine($"The largest number is: {numbers.Max()}");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                        }
                        //Smallest number
                        else if (part1choice == "7")
                        {
                            Console.WriteLine($"The smallest number is: {numbers.Min()}");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                        }
                        //Sum and average numbers
                        else if (part1choice == "8")
                        {
                            int sum = 0;

                            foreach (int number in numbers)
                            {
                                sum += number;
                            }

                            double average = (double)sum / numbers.Count;

                            Console.WriteLine($"The sum of the numbers is: {sum}");
                            Console.WriteLine($"The average of the numbers: {average:F2}");
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();
                        }
                        //Most frequent number
                        else if (part1choice == "9")
                        {
                            int largestCount = 0;

                            for (int value = 10; value <= 20; value++)
                            {
                                int count = 0;

                                foreach (int number in numbers)
                                {
                                    if (number == value)
                                    {
                                        count++;
                                    }
                                }

                                if (count > largestCount)
                                {
                                    largestCount = count;
                                }
                            }
                            Console.WriteLine("The most frequent value(s): ");

                            for (int value = 10; value <= 20; value++)
                            {
                                int count = 0;

                                foreach (int number in numbers)
                                {
                                    if (number == value)
                                    {
                                        count++;
                                    }
                                }

                                if (count == largestCount)
                                {
                                    Console.WriteLine($"{value} appears {count} times.");
                                }
                            }
                            Console.Write("Press any key to continue...");
                            Console.ReadKey();

                        }
                        //Quit
                        else if (part1choice == "10")
                        {
                            Console.Clear();
                            part1end = true;
                        }
                        //Invalid
                        else
                        {
                            Console.WriteLine("Invalid choice");
                            Console.ReadKey();
                        }
                    }
                }

                //Vegetables
                if (choice == "2")
                {
                    int index;
                    List<string> vegetables = new List<string>();
                    
                    vegetables.Add("CARROT");
                    vegetables.Add("BEET");
                    vegetables.Add("CELERY");
                    vegetables.Add("RADISH");
                    vegetables.Add("CABBAGE");


                    bool part2end = false;

                    while(!part2end)
                    {
                        Console.Clear();

                        Console.WriteLine("Here is the list of vegetables: ");
                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {vegetables[i]}");
                        }


                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do with the list?");
                        Console.WriteLine("1 – Remove a vegetable by index");
                        Console.WriteLine("2 – Remove a vegetable by name");
                        Console.WriteLine("3 – Search for a vegetable");
                        Console.WriteLine("4 – Add a vegetable");
                        Console.WriteLine("5 – Sort list");
                        Console.WriteLine("6 – Clear the list");
                        Console.WriteLine("7 - Quit");
                        Console.Write(": ");
                        string part2choice = Console.ReadLine();
                        
                        //Remove a vegetable by index
                        if (part2choice == "1")
                        {
                            Console.Write("Enter index to remove: ");
                            index = Convert.ToInt32(Console.ReadLine());

                            if (index >=1 && index <= vegetables.Count)
                            {
                                vegetables.RemoveAt(index - 1);
                            }
                            else
                            {
                                Console.WriteLine("Index is invalid :(");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        //Remove a vegetable by name
                        else if (part2choice == "2")
                        {
                            Console.Write("Enter vegetable to remove: ");
                            string vegetablename = Console.ReadLine().ToUpper();
                            if (vegetables.Contains(vegetablename))
                            {
                                vegetables.Remove(vegetablename);
                            }
                            else
                            {
                                Console.WriteLine("Vegetable is invalid :(");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        //Search for a vegetable
                        else if (part2choice == "3")
                        {
                            Console.Write("Search for a vegetable: ");
                            string vegetablename = Console.ReadLine().ToUpper();
                            if (vegetables.Contains(vegetablename))
                            {
                                Console.WriteLine($"{vegetablename} {vegetables.IndexOf(vegetablename) + 1}");
                            }
                            else
                            {
                                Console.WriteLine("Vegetable is invalid :(");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        //Add a vegetable
                        else if (part2choice == "4")
                        {
                            Console.Write("Enter a vegetable to add: ");
                            string vegetablename = Console.ReadLine().ToUpper();
                            if (!vegetables.Contains(vegetablename))
                            {
                                vegetables.Add(vegetablename);
                            }
                            else
                            {
                                Console.WriteLine($"{vegetablename} is already in the list");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        //Sort list
                        else if (part2choice == "5")
                        {
                            vegetables.Sort();
                        }
                        //Clear the list
                        else if (part2choice == "6")
                        {
                            vegetables.Clear();
                        }
                        //Quit
                        else if(part2choice == "7") 
                        {
                            Console.Clear();
                            part2end = true;
                        }
                    }

                }

                if (choice == "q")
                {
                    end = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
