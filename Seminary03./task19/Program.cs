// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Please, introduce a five-digit number ") ;
int number , a, a1 ,a2, b, b1, b2 ;
number = Convert.ToInt32(Console.ReadLine()) ;

a = number / 1000 ;
a1 = a / 10 ; 
a2 = a % 10 ; 

b = number % 100 ; 
b1 = b / 10 ; 
b2 = b  % 10 ; 

if ((a1 == b2) && ( a2 == b1 ) ) Console.WriteLine($" {number} --> Yes ") ;
else
{
    Console.WriteLine($" {number} --> Not ") ; 
}

