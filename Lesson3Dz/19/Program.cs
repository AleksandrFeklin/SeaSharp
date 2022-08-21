// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string? numberString = Console.ReadLine()!;
int number = int.Parse(numberString);
int number1 = number / 10000;                            
int number2 = number / 1000 - number1 * 10; 
int number3 = (number/100) - ((number/1000)*10);             
int number4 = (number - (number / 100 * 100)) / 10;     
int number5 = number % 10;                               

if (number > 99999 || number < 10000)
{
    Console.WriteLine("Ошибка, не правильное число");
    Console.WriteLine();
    Console.WriteLine("Введите пятизначное число");
}

else if (number1 == number5 && number2 == number4)
{
    Console.WriteLine("Является Полиндромом");
}
else
{
    Console.WriteLine("Не является Полиндромом");
}



