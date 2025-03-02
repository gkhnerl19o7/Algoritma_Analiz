using System;

class Program
{
    static void Main()
    {
        int a = 2;

        int b = 4;

        long sonuc = UsAl(a, b);
        Console.WriteLine($"{a}^{b} = {sonuc}");
    }

    static long UsAl(int a, int b)
    {
        Console.WriteLine(a);
        if (b == 0) // a^0 = 1
            return 1;
        if (b == 1) // a^1 = a
            return a;
        if(b%2 == 0)
        {
            a = a * a;
            // özyineleme
            return UsAl(a, b / 2);
        }
        
        return a * UsAl(a, b - 1); // özyineleme
    }
}