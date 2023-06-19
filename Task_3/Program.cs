// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет


/*Console.Write("Введите номер заданного дня недели ");
int date = int.Parse(Console.ReadLine()!);

if(date == 1)
{
    Console.WriteLine("Понедельник");
}
if(date == 2)
{
    Console.WriteLine("Вторник");
}
if(date == 3)
{
    Console.WriteLine("Среда");
}
if(date == 4)
{
    Console.WriteLine("Четверг");
}
if(date == 5)
{
    Console.WriteLine("Пятница");
}
if(date == 6)
{
    Console.WriteLine("Суббота");
}
if(date == 7)
{
    Console.WriteLine("Воскресенье");
}
if(date >= 8)
{
    Console.WriteLine("Для этой цифры дня недели не существует");
}*/

Console.Write("Введите номер заданного дня недели ");
int Day = int.Parse(Console.ReadLine()!);
int weekDay1 = 6;
int weekDay2 = 7;

if(Day < weekDay1 || Day > weekDay2)
{
    Console.Write("Нет, это не выходной день");
}
else 
{
    Console.Write("Ура!!! Выходной!!!");
}