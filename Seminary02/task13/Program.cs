// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine(" Please , introduce a number  ");
int number, a ;
number = int.Parse(Console.ReadLine());

if (number < 100) Console.WriteLine(" Do not have the 3 digit ");
    else if ((number >= 100) && (number < 1000))
    {
        a = number % 10;
        Console.WriteLine($" {number} --> {a} ");
    }
    else if ((number >= 1000) && (number < 10000))
    {
        a = (number % 100) / 10;
        Console.WriteLine($" {number} --> {a} ");
    }
    else if ((number >= 10000) && (number < 100000))
    {
        a = (number % 1000) / 100;
        Console.WriteLine($" {number} --> {a} ");
    }
else
{
    Console.WriteLine(" Please , try another number  ");
}    


