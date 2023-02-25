// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] dotA = new int[3];
System.Console.WriteLine("Введите кооординаты точки A");
System.Console.Write("X = ");
dotA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y = ");
dotA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Z = ");
dotA[2] = Convert.ToInt32(Console.ReadLine());

int[] dotB = new int[3];
System.Console.WriteLine("Введите кооординаты точки B");
System.Console.Write("X = ");
dotB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y = ");
dotB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Z = ");
dotB[2] = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(dotA[0] - dotB[0], 2) + Math.Pow(dotA[1] - dotB[1], 2) + Math.Pow(dotA[2] - dotB[2], 2));
dist = Math.Round(dist, 2);
System.Console.WriteLine("Расстояние между точками А и В: " + dist);