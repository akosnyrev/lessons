Console.Write("Введите первое число:");
double a = Convert.ToInt32( Console.ReadLine());
Console.Write("Введите второе число:");
double b = Convert.ToInt32(Console.ReadLine());
if (a/b==b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}