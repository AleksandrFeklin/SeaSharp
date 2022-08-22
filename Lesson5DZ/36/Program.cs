// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] createArray()
{
    var random = new Random();
    var result = new int[6];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-1000, 1000);
    }
    return result;
}

int Summnumbers(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
        result += arr[i];


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
Console.Write("Сумма элементов на нечётных позициях =  ");
Console.WriteLine(Summnumbers(array));