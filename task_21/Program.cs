// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// d = (x2 — x1)^2 + (y2 — y1)^2 + (z2 — z1)^2, где x1, y1 и z1 — координаты первой точки A x2, y2 и z2 — координаты второй точки B.

Console.Write("Введите координату первой точки, x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки, y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки, z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки, x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки, y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки, z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между двумя точками: {Math.Round(distance, 2)}");