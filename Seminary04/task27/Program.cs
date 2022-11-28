// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine(" Please , introduce to numbers : ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0 ) 
    {
        int n = num ; 
        num = num % 10 ; 
        sum = sum + num ; 
        num = n / 10 ; 
    }
    return sum ;
}

int result = SumDigits(number);
Console.WriteLine(result);


