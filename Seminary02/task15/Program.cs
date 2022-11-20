// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Introduce a number ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1 ) Console.WriteLine($" {day} --> Not ");
else if (day == 2 ) Console.WriteLine($" {day} --> Not ");
else if (day == 3 ) Console.WriteLine($" {day} --> Not ");
else if (day == 4 ) Console.WriteLine($" {day} --> Not ");
else if (day == 5 ) Console.WriteLine($" {day} --> Not ");
else if (day == 6 ) Console.WriteLine($" {day} --> Yes ");
else if (day == 7 ) Console.WriteLine($" {day} --> Yes ");
else  Console.WriteLine($" {day} --> do not existe ");