// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76




double[] createArray()
{
    var random = new Random();
    var result = new double[6];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-1000, 1000);
    }
    return result;
}
void DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }

        result = max - min;

    }

    Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + result);
}
void viewArr(double[] arr)
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
    Console.Write("Задан массив : ");
    Console.WriteLine(result);

}


double[] array = createArray();
viewArr(array);
Console.WriteLine();
DifferenceMaxMin(array);


