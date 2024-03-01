using System;

class Program
{
    static int MultiplyInRange(int start, int end)
    {
        int result = 1;
        for (int i = start; i <= end; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main(string[] args)
    {
        //Тут вводити межі діапазону
        int start = 1; int end = 5;

        int product = MultiplyInRange(start, end);
        Console.WriteLine($"Добуток чисел в діапазоні від {start} до {end} дорівнює {product}");
    }
}