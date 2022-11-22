// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x,  y,  z,
    x1, y1, z1, 
    x2, y2, z2 ;
double result;

Console.WriteLine("Please, introduce coordinates X,Y,Z of point A ");
x1 = Convert.ToInt32(Console.ReadLine());
y1 = Convert.ToInt32(Console.ReadLine());
z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, introduce coordinates X,Y,Z of point B ");
x2 = Convert.ToInt32(Console.ReadLine());
y2 = Convert.ToInt32(Console.ReadLine());
z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Point A ({x1}, {y1}, {z1}) ; Point B ({x2}, {y2} , {z2}) ");

x = x1 - x2; y = y1 - y2; z = z1 - z2;

result = Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)) + (Math.Pow(z, 2)));
Console.WriteLine($"Point A ({x1}, {y1}, {z1}) ; Point B ({x2}, {y2} , {z2}) --> {result} ");






