// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine(" Please introduce 3 numbers ");
int numberA, numberB, numberC, max ;
numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());
numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You've introduced the following numbers :");
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(numberC);

max = numberA;

if ( max < numberB )
{
    max = numberB;
}
if ( max < numberC )
{
    max = numberC;
}

Console.Write(" max = ");
Console.WriteLine(max);
