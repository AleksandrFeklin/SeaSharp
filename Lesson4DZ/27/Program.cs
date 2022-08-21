// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine(" Программа, которая принимает на вход число и выдаёт сумму цифр в числе");
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);

  int SumNumber(int numberN){
    
    int count = Convert.ToString(numberN).Length;
    int digit = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      digit = numberN - numberN % 10;
      result = result + (numberN - digit);
      numberN = numberN / 10;
    }
   return result;
  }

int Summ = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + Summ);