//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        // Задаем значения M и N
        int M = 1;
        int N = 10;

        // Выводим натуральные числа от M до N
        PrintNaturalNumbers(M, N);
    }

    // Рекурсивная функция для вывода натуральных чисел от M до N
    static void PrintNaturalNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.WriteLine(current);
            PrintNaturalNumbers(current + 1, end);
        }
    }
}
