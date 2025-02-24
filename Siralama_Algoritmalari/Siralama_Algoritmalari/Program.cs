using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int[] sizes = { 1000, 5000, 10000, 50000, 100000 };
        int k = 10;
        Random rand = new Random();

        foreach (int size in sizes)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, size * 10);
            }

            int[] array1 = (int[])array.Clone();
            int[] array2 = (int[])array.Clone();

            Console.WriteLine($"Array Size: {size}");

            // Method 1: Sort and find k-th smallest
            Stopwatch sw = Stopwatch.StartNew();
            int result1 = FindKthSmallest_Sort(array1, k);
            sw.Stop();
            Console.WriteLine($"Sort Method: {sw.ElapsedMilliseconds} ms, k-th smallest: {result1}");

            // Method 2: Insertion Sort approach
            sw.Restart();
            int result2 = FindKthSmallest_InsertionSort(array2, k);
            sw.Stop();
            Console.WriteLine($"Insertion Sort Method: {sw.ElapsedMilliseconds} ms, k-th smallest: {result2}\n");
        }
    }

    static int FindKthSmallest_Sort(int[] array, int k)
    {
        Array.Sort(array);
        return array[k - 1];
    }

    static int FindKthSmallest_InsertionSort(int[] array, int k)
    {
        int[] kSmallest = new int[k];
        Array.Copy(array, kSmallest, k);
        Array.Sort(kSmallest);

        for (int i = k; i < array.Length; i++)
        {
            if (array[i] < kSmallest[k - 1])
            {
                kSmallest[k - 1] = array[i];
                for (int j = k - 2; j >= 0 && kSmallest[j] > kSmallest[j + 1]; j--)
                {
                    (kSmallest[j], kSmallest[j + 1]) = (kSmallest[j + 1], kSmallest[j]);
                }
            }
        }
        return kSmallest[k - 1];
    }
}

