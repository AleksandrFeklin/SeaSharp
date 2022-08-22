// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] createArray()
{
    var random = new Random();
    var result = new int[8];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    return result;
}

int searchNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}
void viewArr(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            result += arr[i] + ", ";
        }
        if (i == arr.Length - 1)
        {
            result += arr[i] + "]";
        }
    }
    Console.WriteLine(result);
}
int[] array = createArray();
viewArr(array);
Console.Write("Количество чётных чисел в массиве: ");
Console.WriteLine(searchNumbers(array));