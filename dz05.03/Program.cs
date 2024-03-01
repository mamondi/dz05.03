using System;

class Program
{
    static void DisplaySquare(int sideLength, char sym)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(sym + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        DisplaySquare(5, '♥');
    }
}