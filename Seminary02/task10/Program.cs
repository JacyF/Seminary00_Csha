// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine(" Please , introduce three-digit number 'XXX' ");
int number , a ;
number = int.Parse(Console.ReadLine());


if ( number >= 100 && number < 1000 ) 
{
   a = (number % 100) / 10 ;
   Console.Write( number);
   Console.Write(" --> ");
   Console.WriteLine( a ) ;
}
else
{
   Console.Write(" the introduced number was : ");
   Console.WriteLine( number );
}

