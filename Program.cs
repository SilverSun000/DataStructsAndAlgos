using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(100);

        Console.WriteLine("Unsorted Array:");
        DisplayArray(arr);

        int[] sortedArr = Sorting.BubbleSort(arr);

        Console.WriteLine("\nSorted Array:");
        DisplayArray(sortedArr);     
    }

    static int[] GenerateRandomArray(int size)
{
    Random random = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(1, 101);
    }

    return arr;
}

    static void DisplayArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}