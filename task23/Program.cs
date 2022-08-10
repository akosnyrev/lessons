Console.Clear();
Console.WriteLine("введите число:");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ниже представлен ряд кубов всех чисел до {0:G}",n);
for (double i=1;i<(Convert.ToDouble(n)+1);i++)
{
    Console.Write(" {0:G}",Math.Pow(i,3));
}
