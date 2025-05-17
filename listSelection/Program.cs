using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        bool running = true;
        bool sortAscending = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("T - Toggle sort order");
            Console.WriteLine("D - Display sort order");
            Console.WriteLine("F - Find a number");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("Q - Quit");

            Console.Write("\nEnter your choice: ");
            string input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "P":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine("]");
                    }
                    break;

                case "A":
                    Console.Write("Enter a number to add: ");
                    int newNumber = Convert.ToInt32(Console.ReadLine());

                    bool isDuplicate = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == newNumber)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate)
                    {
                        Console.WriteLine("Duplicate entry - not added");
                    }
                    else
                    {
                        numbers.Add(newNumber);
                        Console.WriteLine($"{newNumber} added");

                        // Sort the list
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            for (int j = i + 1; j < numbers.Count; j++)
                            {
                                if ((sortAscending && numbers[i] > numbers[j]) || (!sortAscending && numbers[i] < numbers[j]))
                                {
                                    int temp = numbers[i];
                                    numbers[i] = numbers[j];
                                    numbers[j] = temp;
                                }
                            }
                        }
                    }
                    break;

                case "M":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int total = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            total += numbers[i];
                        }
                        double mean = (double)total / numbers.Count;
                        Console.WriteLine($"The mean is {mean}");
                    }
                    break;

                case "S":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int smallest = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] < smallest)
                            {
                                smallest = numbers[i];
                            }
                        }
                        Console.WriteLine($"The smallest number is {smallest}");
                    }
                    break;

                case "L":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] > largest)
                            {
                                largest = numbers[i];
                            }
                        }
                        Console.WriteLine($"The largest number is {largest}");
                    }
                    break;

                case "F":
                    Console.Write("Enter a number to search for: ");
                    int target = Convert.ToInt32(Console.ReadLine());

                    bool found = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == target)
                        {
                            Console.WriteLine($"{target} found at index {i}");
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine($"{target} not found in the list");
                    }
                    break;

                case "C":
                    numbers.Clear();
                    Console.WriteLine("List cleared");
                    break;

                case "T":
                    sortAscending = !sortAscending;

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        for (int j = i + 1; j < numbers.Count; j++)
                        {
                            if ((sortAscending && numbers[i] > numbers[j]) || (!sortAscending && numbers[i] < numbers[j]))
                            {
                                int temp = numbers[i];
                                numbers[i] = numbers[j];
                                numbers[j] = temp;
                            }
                        }
                    }

                    Console.WriteLine($"Sort order changed to {(sortAscending ? "Ascending" : "Descending")}");
                    break;

                case "D":
                    Console.WriteLine($"Current sort order: {(sortAscending ? "Ascending" : "Descending")}");
                    break;

                case "Q":
                    Console.WriteLine("Goodbye");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Unknown selection, please try again");
                    break;
            }
        }
    }
}
