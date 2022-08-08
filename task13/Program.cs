Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
if (a>99)
{
Console.WriteLine(Convert.ToString(a)[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}