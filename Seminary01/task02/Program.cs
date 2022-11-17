// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine(" Please introduce 2 numbers ");
int numberA, numberB;
numberA = int.Parse(Console.ReadLine());
numberB = int.Parse(Console.ReadLine());

Console.WriteLine("You've introduced the following numbers :");
Console.WriteLine(numberA);
Console.WriteLine(numberB);

if ( numberA > numberB )
{
    Console.Write(" max = ");
    Console.WriteLine(numberA);
    Console.Write(" min = ");
    Console.WriteLine(numberB);
}
if ( numberA < numberB)
{
    Console.Write(" max = ");
    Console.WriteLine(numberB);
    Console.Write(" min = ");
    Console.WriteLine(numberA);
}




