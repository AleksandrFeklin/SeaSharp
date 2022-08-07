//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3



Console.WriteLine("Программа вывода максимума и минимума");

Console.WriteLine("Введите первое число");

string? numberString1 = Console.ReadLine();

int number1 = int.Parse(numberString1!);

Console.WriteLine("Введите второе число");

string? numberString2 = Console.ReadLine();

int number2 = int.Parse(numberString2!);

if(number1 > number2)

{
    Console.WriteLine("Минимальное число " + number2);
    Console.WriteLine("Максимальное число " + number1);
}

else if(number1 < number2)

{
     Console.WriteLine("Минимальное число " + number1);
     Console.WriteLine("Максимальное число " + number2);
}

else 
{
    Console.WriteLine("Введенные числа равны");
}