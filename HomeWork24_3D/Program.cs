﻿/*Найти расстояние между точками в пространстве 3D*/
Console.WriteLine("Введить x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введить z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введить x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine("расстояние = " + AB);
