//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        // Пример массива
        int[] array = { 1, 2, 3, 4, 5 };

        // Вывод элементов массива, начиная с конца
        PrintArrayReversed(array, array.Length - 1);
    }

    // Рекурсивная функция для вывода элементов массива, начиная с конца
    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReversed(arr, index - 1);
        }
    }
}
