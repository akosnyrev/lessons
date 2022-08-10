Console.Clear();
Console.WriteLine("Давайте возведем число А в степень В");
Console.WriteLine("Для этого введите число А:");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь число В:");
int b=Convert.ToInt32(Console.ReadLine());
int result=a;
for (int i=2;i<(b+1);i++)
{
    result=result*a;
}
Console.WriteLine("Результат возведения в степень равен {0:G}",result);
