// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine(" Please , introduce a number  ");
int number, a, b;
number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine(" Do not have the 3 digit ");
else if ((number >= 100) && (number < 1000))
{
    a = number % 10;
    Console.WriteLine($" {number} --> {a} ");
}
else
{
    b = number;
    while (number >= 1000) 
    {
        number = number / 10; 
    }
    a = number % 10;
    Console.WriteLine($" {b} --> {a} ");
}
