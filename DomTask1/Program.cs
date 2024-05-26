// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNaturalNumbers1(int num1, int num2)
{
    if (num2 < num1) return;
    PrintNaturalNumbers1(num1, num2 - 1);
    Console.Write($"{num2} ");
}

void PrintNaturalNumbers2(int num1, int num2)
{
    if (num2 > num1) return;
    Console.Write($"{num1} ");
    PrintNaturalNumbers2(num1 - 1, num2);
}

Console.WriteLine("Введите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 && number2 > 0)
{
    if (number1 < number2)
    {
        PrintNaturalNumbers1(number1, number2);
    }
    else
    {
        PrintNaturalNumbers2(number1, number2);
    }
}
else
{
    Console.Write("Ошибка ввода");
}