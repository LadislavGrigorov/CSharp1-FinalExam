using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = (6 + ((n - 3) / 2) * 3);
        Console.Write(new string('.', (n + 1) / 2));
        Console.Write(new string('*', n));
        Console.Write(new string('.', (n + 1) / 2));
        Console.WriteLine();
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', n / 2 - i));
            Console.Write("*");
            Console.Write(new string('.', n / 2 + i));
            Console.Write("*");
            Console.Write(new string('.', n / 2 + i));
            Console.Write("*");
            Console.Write(new string('.', n / 2 - i));
            Console.WriteLine();
        }
        Console.Write(new string('*', width));
        Console.WriteLine();
        int pointCounter = 1;
        int middlePointCounter = n - 2;
        for (int i = 0; i < (n - 2); i++)
        {
            Console.Write(new string('.', pointCounter));
            Console.Write("*");
            Console.Write(new string('.', middlePointCounter));
            Console.Write("*");
            Console.Write(new string('.', middlePointCounter));
            Console.Write("*");
            Console.Write(new string('.', pointCounter));
            Console.WriteLine();
            pointCounter++;
            middlePointCounter--;
        }
        Console.Write(new string('.', n - 1));
        Console.Write(new string('*', 3));
        Console.Write(new string('.', n - 1));
        Console.WriteLine();
        Console.Write(new string('.', n));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n));
        Console.WriteLine();
    }
}
