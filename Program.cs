// Lesson 1
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"N={N}, M={M}");
// if (M>N)
// for (int i = N; i <= M; i++)
//     Console.Write($" {i}");
// else
//     for (int i = M; i <= N; i++)
//         Console.Write($" {i}");

// Lesson 2

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m -1, 1);
// else return akkerman(m -1, akkerman(m, n -1));
// }

// Console.Write($" {akkerman(m, n)} ");

// Lesson 3

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = [ 1, 2, 3, 4, 5 ];
        MyArray(array, array.Length - 1);
    }

    static void MyArray(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.Write(array[index]);
        MyArray(array, index - 1);
    }
}
