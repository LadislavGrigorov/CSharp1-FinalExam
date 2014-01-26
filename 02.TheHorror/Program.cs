using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        BigInteger numberCounter = 0;
        BigInteger sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if ((i % 2 == 0) && ((int)number[i] >= 48) && ((int)number[i] <= 57))
            {
                sum += (BigInteger)(number[i] - '0');
                numberCounter++;
            }
        }
        Console.WriteLine("{0} {1}", numberCounter, sum);
    }
}
