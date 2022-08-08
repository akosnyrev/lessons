
Console.WriteLine("Введите первое число:");
int a=Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b=Convert.ToInt32( Console.ReadLine());
if ((a%b)==0)
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine("Не кратно, остаток ");
    Console.WriteLine(a%b);
}