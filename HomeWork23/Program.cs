/*Задать номер четверти, показать диапазоны для возможных координат*/
Console.WriteLine("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
    Console.WriteLine("диапазоны для возможных координат: x > 0, y > 0");
else if (a == 2)
    Console.WriteLine("диапазоны для возможных координат: x < 0, y > 0");
else if (a == 3)
    Console.WriteLine("диапазоны для возможных координат: x < 0 , y < 0");
else if (a == 4)
    Console.WriteLine("диапазоны для возможных координат: x > 0, y < 0");