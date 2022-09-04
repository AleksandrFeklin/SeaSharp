// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




void SummOfMN(int m, int n, int summ = 0)
{
    //Console.WriteLine($"{i}, {j}, {sum}");
    summ += m;
    m++;
    if (m > n)
    {
        Console.WriteLine($"Сумма чисел в  интервале равна : {summ}");
        return;
    }
    SummOfMN(m, n, summ);
}
SummOfMN(4, 8);