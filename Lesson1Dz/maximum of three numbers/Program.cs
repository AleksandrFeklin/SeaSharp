//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Программа вывода максимума из трёх чисел");

Console.WriteLine("Введите первое число");

string? numberString1 = Console.ReadLine();

int number1 = int.Parse(numberString1!);

Console.WriteLine("Введите второе число");

string? numberString2 = Console.ReadLine();

int number2 = int.Parse(numberString2!);
Console.WriteLine("Введите третье число");

string? numberString3 = Console.ReadLine();

int number3 = int.Parse(numberString3!);
int max = 0;

if (number1 >= number2 && number1 >= number3)
{
     max = number1;
}
              else if (number2 >= number1 && number2 >= number3)
                    {
                         max = number2;
                    }


              else if (number3 >= number1 && number3 >= number2)
                    {
                         max = number3;
                    }                   

Console.WriteLine("Максимальное число " + max);
