//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Программа вывода чётных чисел от 1 до N");

Console.WriteLine("Введите число");

string? numberString = Console.ReadLine();
Console.WriteLine("Вывод чётных чисел:");

int Number = int.Parse(numberString!);

while(Number > 1)
{
   if(Number%2 == 0)
      {
      Console.WriteLine(Number--);
      }
Number --;
}