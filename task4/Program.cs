int[] array=new int[3];
int i_max=0;
Console.WriteLine("Введите три числа:");
for (int i = 0; i < array.Length; i++)
{
   array[i]= Convert.ToInt32( Console.ReadLine());
    if (array[i]>array[i_max])
    {
        i_max=i;
    }
}
Console.Write("Максимальное введенное число: ");
Console.WriteLine(array[i_max]);

