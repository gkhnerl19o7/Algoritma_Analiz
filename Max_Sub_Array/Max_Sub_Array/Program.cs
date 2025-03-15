class Program
{
    static int MaxSubArray(int[] arr)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;

        foreach (int num in arr)
        {
            currentSum = Math.Max(num, currentSum + num);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }

    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Maksimum Alt Dizi Toplamı: " + MaxSubArray(arr));
        // Çıktı: 6 (Alt dizi: [4, -1, 2, 1])
    }
}
