using System;
//По факту, повністю виконана задача чатомгпт, сам я реально не вдупляв, як це прописати
class Program
{
    static void Sort(int[] arr, bool ascending)   
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((ascending && arr[j] > arr[j + 1]) || (!ascending && arr[j] < arr[j + 1]))
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Введіть '1' для сортування за зростанням або '0' для сортування за зменшенням:");
        int choice = Convert.ToInt32(Console.ReadLine());

        bool ascending = choice == 1 ? true : false;

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        Sort(array, ascending);

        Console.WriteLine($"Відсортований масив {(ascending ? "за зростанням" : "за зменшенням")}:");
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}