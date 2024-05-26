// Вычислить факториал N!

int rezult = 1;

void FactorialN(int n, int x)
{
    if(x == n + 1)
    {
        Console.WriteLine($"Факториал числа N равен {rezult}");
        return;
    }
    
    rezult *= x;

    FactorialN(n, x + 1);
}

Console.WriteLine("Введи значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;

FactorialN(n, x);