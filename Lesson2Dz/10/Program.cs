// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Random random = new Random();

int randomNumber = random.Next(100, 1000); 
Console.WriteLine ( "Случайное трёхзначное число = "+randomNumber);

int result = (randomNumber % 100) /10;

Console.WriteLine(result);

// Console.WriteLine("Введите трёхзначное число");

// string? numberString = Console.ReadLine();

// int number = int.Parse(numberString!);

// int firstNumber = (number / 100) * 100; 

// int result = (number -  firstNumber) / 10; 

// Console.WriteLine("Результат = " + result); 
