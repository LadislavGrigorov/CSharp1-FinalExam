using System;

class Program
{
    static void Main()
    {
        checked
        {


            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong result = 0;
            ulong resultRemaindBy3 = 0;
            if (b == 3)
            {
                result = a + c;
            }
            else if (b == 6)
            {
                result = a * c;
            }
            else if (b == 9)
            {
                result = a % c;
            }

            if (result % 3 == 0)
            {
                resultRemaindBy3 = result / 3;
                Console.WriteLine(resultRemaindBy3);
                Console.WriteLine(result);
            }
            else
            {
                resultRemaindBy3 = result % 3;
                Console.WriteLine(resultRemaindBy3);
                Console.WriteLine(result);
            }
        }
    }
}
