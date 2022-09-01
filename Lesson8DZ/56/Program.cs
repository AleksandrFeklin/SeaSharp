// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(0, 10);
    return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}
int ReadInputData()
{
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}
int SummLine(int[,] array, int i)
{
    int summ = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ += array[i, j];
    }
    return summ;
}

void MinSummLine(int[,] array)
{
    int minsumm = 0;
    int summline = SummLine(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = SummLine(array, i);
        if (summline > temp)
        {
            summline = temp;
            minsumm = i;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов под № {minsumm + 1}.");
    // отсчёт от 1 строки ,а не от нуля  
    Console.WriteLine($"Сумма Элементов = {summline}.");
}


Console.WriteLine("Введите число строк (m): ");
int numberOfRows = ReadInputData();
Console.WriteLine("Введите число столбцов (n): ");
int numberOfColumns = ReadInputData();
int[,] array = CreateArrayWithRandomNumbers(numberOfRows, numberOfColumns);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
MinSummLine(array);



