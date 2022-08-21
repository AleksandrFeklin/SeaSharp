// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int a = 8;
int[] CreateArray()
{
    int[] array = new int[a];
    var random = new Random();

    for (int i = 0; i < a; i++)
        array[i] = random.Next(0, 99);

    return array;
}

var array = CreateArray();

Console.Write("[");
int i = 0;
while ( i < a)
{
    Console.Write(array[i]);
    i++;
    if (i < a)
    Console.Write(", ");
}
Console.WriteLine("]");

