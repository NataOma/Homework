// Вычислим факториал числа n


int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        // Console.WriteLine($"Стоп при n={n}");
        return 1;

    }
    // Console.WriteLine(n);
    
    int rez = (n * Fact(n - 1));
    Console.WriteLine($"Возврат n= {n}, Fact={rez}");
    return rez;
}

Console.Write(Fact(5));



// int Factorial(int n)
// {
// 	if(n == 1) return 1;
// 	return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5)); // 120


// int Fact(int n)
// {
//         if (n == 1 || n == 0)
//     {
//         Console.WriteLine($"Stop: {n}");
//         return 1;
//     }
//     Console.WriteLine(n);
//     return n * Fact(n - 1);
// }

// Console.WriteLine(Fact(5));