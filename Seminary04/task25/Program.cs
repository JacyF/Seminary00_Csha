// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine(" Please , introduce to numbers : ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());


int ExpDigits(int n1, int n2)
{
    int exp ;
    exp = (int) Math.Pow(number1, number2);
    return exp;
}

if ( number1 > 0 && number2 > 0 )
{
 int expDigits = ExpDigits(number1, number2);
 Console.WriteLine($" {number1} , {number2} --> {expDigits} ");
}
else 
{
    Console.WriteLine(" Please , introduce natural numbers : ");
}
