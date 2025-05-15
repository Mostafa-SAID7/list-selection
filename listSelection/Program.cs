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
            
            //Toggle sort order** (Ascending / Descending)        
            Console.WriteLine("T - Toggle sort order");
            
            //Display current sort order
            Console.WriteLine("D - Display sort order");

            //Find a number** by value and display its index
            Console.WriteLine("F - Find a number");

            //Clear the list
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("Q - Quit");

            Console.Write("\nEnter your choice: ");
            string input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "P":
                    if (numbers.Count == 0)
                        Console.WriteLine("[] - the list is empty");
                    else
                    {
                        Console.Write("[ ");
                        foreach (int num in numbers)
                            Console.Write(num + " ");
                        Console.WriteLine("]");
                    }
                    break;

                case "A":
                    Console.Write("Enter a number to add: ");
                    if (int.TryParse(Console.ReadLine(), out int newNumber))
                    {
                        if (numbers.Contains(newNumber))
                        {
                            Console.WriteLine("Duplicate entry - not added");
                        }
                        else
                        {
                            numbers.Add(newNumber);
                            Console.WriteLine($"{newNumber} added");

                            // Sort the list after adding
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
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Try again.");
                    }
                    break;

                case "M":
                    if (numbers.Count == 0)
                        Console.WriteLine("Unable to calculate the mean - no data");
                    else
                    {
                        int total = 0;
                        foreach (int num in numbers)
                            total += num;
                        double mean = (double)total / numbers.Count;
                        Console.WriteLine($"The mean is {mean}");
                    }
                    break;

                case "S":
                    if (numbers.Count == 0)
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    else
                    {
                        int smallest = numbers[0];
                        foreach (int num in numbers)
                            if (num < smallest)
                                smallest = num;
                        Console.WriteLine($"The smallest number is {smallest}");
                    }
                    break;

                case "L":
                    if (numbers.Count == 0)
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    else
                    {
                        int largest = numbers[0];
                        foreach (int num in numbers)
                            if (num > largest)
                                largest = num;
                        Console.WriteLine($"The largest number is {largest}");
                    }
                    break;

                case "F":
                    Console.Write("Enter a number to search for: ");
                    if (int.TryParse(Console.ReadLine(), out int target))
                    {
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
                            Console.WriteLine($"{target} not found in the list");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break;

                case "C":
                    numbers.Clear();
                    Console.WriteLine("List cleared");
                    break;

                case "T":
                    sortAscending = !sortAscending;

                    // Manual sort again with new direction
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
