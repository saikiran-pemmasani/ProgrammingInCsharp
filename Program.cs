// using System;

// namespace IntroductionToProgramming//ProgrammingInCSharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Introduction to Programming
//             Console.WriteLine("Running Introduction to Programming (Basic Syntax)...");
//             // IntroductionToProgramming.VariablesAndDataTypes.RunExample();
//             // IntroductionToProgramming.ControlStructures.RunExample();
//             //IntroductionToProgramming.BasicSyntax.RunExample();

//             // Data Structures
//             // Console.WriteLine("Running Data Structures...");
//             // DataStructures.Arrays.ArraysBasics.RunExample();
//             // DataStructures.Strings.StringManipulation.RunExample();
//              DataStructures.Dictionaries.DictionaryOperations.RunExample();

//             // Sorting Algorithms
//             // Console.WriteLine("Running Sorting Algorithms...");
//             // SortingAlgorithms.BubbleSort.RunExample();
//             // SortingAlgorithms.QuickSort.RunExample();
//             // SortingAlgorithms.MergeSort.RunExample();

//             // Searching Algorithms
//             // Console.WriteLine("Running Searching Algorithms...");
//             // SearchingAlgorithms.BinarySearch.RunExample();
//             // SearchingAlgorithms.LinearSearch.RunExample();
//             // SearchingAlgorithms.SearchTimeComparison.RunExample();

//             // Big O Notation
//             // Console.WriteLine("Running Big O Notation Examples...");
//             // BigOExamples.BigOExamples.RunExample();

//             // Algorithms (Recursion, Divide and Conquer, Dynamic Programming)
//             // Console.WriteLine("Running Algorithms...");
//             // Algorithms.Recursion.Fibonacci.RunExample();
//             // Algorithms.DivideAndConquer.MergeSort.RunExample();
//             // Algorithms.DynamicProgramming.KnapsackProblem.RunExample();

//             // Object-Oriented Programming (OOP)
//             // Console.WriteLine("Running Object-Oriented Programming Examples...");
//             // OOPs.ClassesAndObjects.ClassesAndObjectsExample.RunExample();
//             // OOPs.Inheritance.InheritanceExample.RunExample();
//             // OOPs.Polymorphism.PolymorphismExample.RunExample();
//             // OOPs.Interfaces.InterfacesExample.RunExample();

//             // Program execution completed
//             Console.WriteLine("\nProgram execution completed.");
//         }
//     }
// }
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary with key as int and value as double
        Dictionary<int, double> randomDict = new Dictionary<int, double>();
        Random rand = new Random();

        // Populate the dictionary with 10 items, keys between 1-20, values random doubles
        for (int i = 0; i < 10; i++)
        {
            int key = rand.Next(1, 21); // Generate a key between 1 and 20
            double value = rand.NextDouble(); // Generate a random double
            if (!randomDict.ContainsKey(key)) // Ensure no duplicate keys
            {
                randomDict.Add(key, value);
            }
            else
            {
                i--; // Try again for a new key if duplicate
            }
        }

        // Display the dictionary content
        Console.WriteLine("Dictionary Contents:");
        foreach (var kvp in randomDict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Search for 4 random keys (between 1-20) in the dictionary
        Console.WriteLine("\nSearch Results:");
        for (int i = 0; i < 4; i++)
        {
            int searchKey = rand.Next(1, 21); // Generate a random search key between 1 and 20
            if (randomDict.ContainsKey(searchKey))
            {
                Console.WriteLine($"Key {searchKey} found with value: {randomDict[searchKey]}");
            }
            else
            {
                Console.WriteLine($"Key {searchKey} not found.");
            }
        }
    }
}
