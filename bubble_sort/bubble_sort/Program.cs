using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int[] sizes = { 1000, 5000, 10000, 50000, 100000 };
        Random rand = new Random();

        foreach (int size in sizes)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, size * 10);
            }

            Stopwatch sw = Stopwatch.StartNew();
            BubbleSort(array);
            sw.Stop();

            Console.WriteLine($"Array Size: {size}, Time Elapsed: {sw.ElapsedMilliseconds} ms");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
}
