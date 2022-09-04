// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int Ackermann(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    return Ackermann((m - 1), Ackermann(m, n - 1));
}
Console.WriteLine(Ackermann(2, 3));
