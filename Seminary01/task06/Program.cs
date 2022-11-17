// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine(" Please introduce a number ");

int number;
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

if ( number % 2 == 0 )
{
   Console.WriteLine(" yes "); 
}
else
{
     Console.WriteLine("no "); 
}


