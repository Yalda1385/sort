using System;
using SystemAlgorithmsLibrary;

class Program
{
    static void Main()
    {
        int[] intArray = { 64, 34, 25, 12, 22, 11, 90 };
        string[] stringArray = { "blue", "red", "yellow", "pink" };

        ISorter<int> bubbleSorter = new BubbleSort<int>();
        ISorter<int> selectionSorter = new SelectionSort<int>();
        ISorter<int> mergeSorter = new MerageSort<int>();
        ISorter<int> insertionSorter = new InesrtionSort<int>();

        Console.WriteLine("Orginal int array:");
        PrintArray(intArray);

        bubbleSorter.SortAscending(intArray);
        Console.WriteLine("\nBubble Sort Ascending (int array):");
        PrintArray(intArray);

        selectionSorter.SortDescending(intArray);
        Console.WriteLine("\nSelection Sort Descending (int array):");
        PrintArray(intArray);

        ISorter<string> stringSorter = new BubbleSort<string>();
        stringSorter.SortAscending("\nBubblr Sort Ascending (string array):");
        PrintArray(stringArray);

        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}