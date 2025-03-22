using System;

class DynamicArray<T>
{
    private T[] array;
    private int count;
    private int resizeCount;

    public DynamicArray(int capacity = 4)
    {
        array = new T[capacity];
        count = 0;
        resizeCount = 0;
    }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Resize();
        }
        array[count++] = item;
    }

    private void Resize()
    {
        int newSize = array.Length * 2;
        T[] newArray = new T[newSize];
        Array.Copy(array, newArray, array.Length);
        array = newArray;
        resizeCount++;

        Console.WriteLine($"Resize yapıldı! Yeni kapasite: {newSize}, Toplam resize sayısı: {resizeCount}");
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            return array[index];
        }
    }

    public int Count => count;
    public int ResizeCount => resizeCount;

    public void PrintAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        DynamicArray<int> dynamicArray = new DynamicArray<int>();

        for (int i = 1; i <= 1000; i++)
        {
            dynamicArray.Add(i);
        }

        dynamicArray.PrintAll();
        Console.WriteLine("Eleman Sayısı: " + dynamicArray.Count);
        Console.WriteLine("Toplam Resize Sayısı: " + dynamicArray.ResizeCount);
    }
}
