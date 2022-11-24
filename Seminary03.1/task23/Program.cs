// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int number, count;
Console.WriteLine(" Please, introduce a number ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {number} --> ");

count = 1;

while (count <= number)
{
    Console.Write($" {count} | {Math.Pow(count, 3)} ");
    count++;
    Console.WriteLine();
}


