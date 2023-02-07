/*Найти расстояние между точками в пространстве 2D*/


Console.WriteLine("Введить x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введить y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine(AB);