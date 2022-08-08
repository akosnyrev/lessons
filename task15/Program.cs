
Console.WriteLine("Введите номер дня недели:");
int a=Convert.ToInt32(Console.ReadLine());
if ((a==6)^(a==7))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий");
}
