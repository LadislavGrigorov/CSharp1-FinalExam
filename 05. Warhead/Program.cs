using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[16, 16];

        for (int rows = 0; rows < 16; rows++)
        {
            string number = Console.ReadLine();
            for (int cols = 0; cols < 16; cols++)
            {
                matrix[rows, cols] = number[cols] - '0';
            }
        }
        bool defusedOrNot = true;
        int countCapacitors = 0;
        int leftCount = 0;
        int rightCount = 0;
        while (defusedOrNot)
        {
            string operation = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (operation == "hover")
            {
                if (matrix[row, col] == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            if (((operation == "operate") && (matrix[row, col] == 1)) && ((row == 0) || (col == 0) || (row == 15) || (col == 15)))
            {
                leftCount = 0;
                rightCount = 0;
                Console.WriteLine("missed");
                for (int rows = 1; rows < 15; rows++)
                {
                    for (int cols = 1; cols < 7; cols++)
                    {
                        if ((matrix[rows, cols] == 0) && (matrix[rows + 1, cols] == 1) && (matrix[rows + 1, cols - 1] == 1) && (matrix[rows + 1, cols + 1] == 1) && (matrix[rows - 1, cols] == 1) && (matrix[rows - 1, cols - 1] == 1) && (matrix[rows - 1, cols + 1] == 1) && (matrix[rows, cols - 1] == 1) && (matrix[rows, cols + 1] == 1))
                        {
                            leftCount++;
                        }
                    }
                    for (int cols = 9; cols < 15; cols++)
                    {
                        if ((matrix[rows, cols] == 0) && (matrix[rows + 1, cols] == 1) && (matrix[rows + 1, cols - 1] == 1) && (matrix[rows + 1, cols + 1] == 1) && (matrix[rows - 1, cols] == 1) && (matrix[rows - 1, cols - 1] == 1) && (matrix[rows - 1, cols + 1] == 1) && (matrix[rows, cols - 1] == 1) && (matrix[rows, cols + 1] == 1))
                        {
                            rightCount++;
                        }
                    }
                }
                Console.WriteLine(leftCount + rightCount);
                Console.WriteLine("BOOM");
                defusedOrNot = false;
            }
            else if ((operation == "operate") && (matrix[row, col] == 0) && (matrix[row + 1, col] == 1) && (matrix[row + 1, col - 1] == 1) && (matrix[row + 1, col + 1] == 1) && (matrix[row - 1, col] == 1) && (matrix[row - 1, col - 1] == 1) && (matrix[row - 1, col + 1] == 1) && (matrix[row, col - 1] == 1) && (matrix[row, col + 1] == 1))
            {
                matrix[row + 1, col] = 0;
                matrix[row + 1, col - 1] = 0;
                matrix[row + 1, col + 1] = 0;
                matrix[row - 1, col] = 0;
                matrix[row - 1, col - 1] = 0;
                matrix[row - 1, col + 1] = 0;
                matrix[row, col - 1] = 0;
                matrix[row, col + 1] = 0;
                for (int rows = 1; rows < 15; rows++)
                {
                    for (int cols = 1; cols < 7; cols++)
                    {
                        if ((matrix[rows, cols] == 0) && (matrix[rows + 1, cols] == 1) && (matrix[rows + 1, cols - 1] == 1) && (matrix[rows + 1, cols + 1] == 1) && (matrix[rows - 1, cols] == 1) && (matrix[rows - 1, cols - 1] == 1) && (matrix[rows - 1, cols + 1] == 1) && (matrix[rows, cols - 1] == 1) && (matrix[rows, cols + 1] == 1))
                        {
                            leftCount++;
                        }
                    }
                    for (int cols = 9; cols < 15; cols++)
                    {
                        if ((matrix[rows, cols] == 0) && (matrix[rows + 1, cols] == 1) && (matrix[rows + 1, cols - 1] == 1) && (matrix[rows + 1, cols + 1] == 1) && (matrix[rows - 1, cols] == 1) && (matrix[rows - 1, cols - 1] == 1) && (matrix[rows - 1, cols + 1] == 1) && (matrix[rows, cols - 1] == 1) && (matrix[rows, cols + 1] == 1))
                        {
                            rightCount++;
                        }
                    }
                }
                if (leftCount == 0)
                {
                    Console.WriteLine(rightCount);
                    Console.WriteLine("disarmed");
                    defusedOrNot = false;
                }else if (rightCount == 0)
                {
                    Console.WriteLine(leftCount);
                    Console.WriteLine("disarmed");
                    defusedOrNot = false;
                }

            }
            else if ((operation == "operate") && (matrix[row, col] == 1)) //boom
            {
                leftCount = 0;
                rightCount = 0;
                Console.WriteLine("missed");
                for (int rows = 1; rows < 15; rows++)
                {
                    for (int cols = 1; cols < 7; cols++)
                    {
                        if ((matrix[rows, cols] == 0) && (matrix[rows + 1, cols] == 1) && (matrix[rows + 1, cols - 1] == 1) && (matrix[rows + 1, cols + 1] == 1) && (matrix[rows - 1, cols] == 1) && (matrix[rows - 1, cols - 1] == 1) && (matrix[rows - 1, cols + 1] == 1) && (matrix[rows, cols - 1] == 1) && (matrix[rows, cols + 1] == 1))
                        {
                            leftCount++;
                        }
                    }
                    for (int cols = 9; cols < 15; cols++)
                    {
                        if ((matrix[rows, cols] == 0) && (matrix[rows + 1, cols] == 1) && (matrix[rows + 1, cols - 1] == 1) && (matrix[rows + 1, cols + 1] == 1) && (matrix[rows - 1, cols] == 1) && (matrix[rows - 1, cols - 1] == 1) && (matrix[rows - 1, cols + 1] == 1) && (matrix[rows, cols - 1] == 1) && (matrix[rows, cols + 1] == 1))
                        {
                            rightCount++;
                        }
                    }
                }
                Console.WriteLine(leftCount + rightCount);
                Console.WriteLine("BOOM");
                defusedOrNot = false;

            }
        }
    }
}