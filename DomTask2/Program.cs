// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29
// m = 11, n = 3 -> A(m,n) = 16381

int FunkcAckerman(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = FunkcAckerman(n, m - 1);
        }
        n = n - 1;  
    }
    return m + 1;
}

Console.WriteLine("Введите два неотрицательных целых числа: ");
int numN = Convert.ToInt32(Console.ReadLine());
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write(FunkcAckerman(numN, numM));