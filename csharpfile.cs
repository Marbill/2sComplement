using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static int numberOfOnes(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;
            int total = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    total += 1;
                }
                pos--;
                i++;
            }
            return total;
        }
        static int[,] inputData(int size)
        {
            var pairs = new int[size, 2];
            for (int i = 0; i < size; i++)
            {
                var numbers = new string[2];
                numbers = ReadLine().Split();
                for (int j = 0; j < numbers.Length; j++)
                {
                    pairs[i, j] = Convert.ToInt32(numbers[j]);
                }
            }

            return pairs;
        }
        static int findOnes(int x, int y)
        {
            int total = 0;
            for (int i = x; i <= y; i++)
            {
                total += numberOfOnes(i);
            }

            return total;
        }
        static void Main(string[] args)
        {
            int s = Convert.ToInt32(ReadLine());
            int[,] t = inputData(s);

            for (int i = 0; i < s; i++)
            {
                int x = 0;
                int y = 0;
                for (int j = 0; j < 2; j++)
                {
                    if (j==0)
                    {
                        x = t[i, j];
                    }
                    else
                    {
                        y = t[i, j];
                    }
                }
                WriteLine(findOnes(x, y));
            }
        }
    }
}
