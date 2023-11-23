//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

using System;

class Program
{
    static void Main()
    {
        // Пример вызова функции Аккермана
        int m = 2;
        int n = 3;

        Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");
    }

    // Рекурсивная функция для вычисления функции Аккермана
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            // В случае отрицательных чисел можно вернуть, например, -1 или бросить исключение.
            // В данном примере просто вернем -1.
            return -1;
        }
    }
}
