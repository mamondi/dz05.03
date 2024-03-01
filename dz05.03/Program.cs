using System;

class Program
{
    static bool IsFibonacci(int num)
    {
        bool IsPerfectSquare(int x)
        {
            int sqrt = (int)Math.Sqrt(x);
            return sqrt * sqrt == x;
        }

        return IsPerfectSquare(5 * num * num + 4) || IsPerfectSquare(5 * num * num - 4);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        int number = 8;
        bool isFibonacci = IsFibonacci(number);
        Console.WriteLine($"Число {number} є числом Фібоначчі: {isFibonacci}");
    }
}