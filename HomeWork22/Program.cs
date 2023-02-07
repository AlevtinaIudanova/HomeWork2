/*По двум заданным числам проверять является ли одно квадратом другого*/

Console.WriteLine("Enter number first: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number second: ");
int num2 = int.Parse(Console.ReadLine());


if (num1 == num2 * num2)
{
    Console.WriteLine("num1 - квадрат num2");
}
else
{
    Console.WriteLine("num1 - не является квадратом num2");
}
if (num2 == num1 * num1)
{
    Console.WriteLine("num2 - квадрат num1");
}
else
{
    Console.WriteLine("num2 - не является квадратом num1");
}