// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// Вводим массив с клавиатуры:

// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"arr[{i + 1}] = ");
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// Выводим введенный ассив на консоль:

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(i < arr.Length - 1 ? $"{arr[i]} " : $"{arr[i]}");
//     }
//     Console.Write("]");
// }
//PrintArray(arr);


static void PrintArrBackwards(int[] arr, int i)
{
    if (i < arr.Length)
    {
        PrintArrBackwards(arr, i + 1);
        Console.Write($"{arr[i]} ");
    }
}


int[] array = { 1, 3, 5, 8, 3, 10, 88 };
PrintArrBackwards(array, 0);