// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату первой точки Xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки Ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки Za: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки Xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки Yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки Zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

 double distance = Math.Round(Math.Sqrt((Math.Pow(xb - xa ,2))+(Math.Pow(yb - ya,2)) + (Math.Pow(zb - za,2))), 2);
 Console.WriteLine($"растояние между точками {distance} ");