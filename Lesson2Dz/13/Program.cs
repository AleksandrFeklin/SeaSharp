// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine ("Введите число: ");
string? numberString = Console.ReadLine ();
int number=  int.Parse (numberString!);

if (number>999)
{
     while (number > 999)
     {
        number = (number/10);
     }
}

if (number<0)
    number = number*-1;
if (number<100)
    Console.WriteLine ("Третья цифра отсутствует ");
else
    Console.WriteLine (number%10);