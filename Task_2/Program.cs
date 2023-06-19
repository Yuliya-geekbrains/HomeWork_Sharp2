//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// (Максимум 10000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

int number = new Random().Next(10000);
int num1 = number % 10;
int num2 = number / 10 % 10;

if(number >= 100 && number <= 999)
{
    Console.Write($"В числе {number} третьей цифрой является {num1}");   
}
else if(number > 999)
{
       Console.Write($"В числе {number} третьей цифрой является {num2}");
}
else Console.Write("Третьей цифры нет");

