Console.Clear();
Console.WriteLine("Ниже ваш массив из 8 случайны чисел");
Random rnd=new Random();
int[] array=new int[8];
for (int i=0;i<8;i++)
{
    array[i]=rnd.Next();
    Console.WriteLine(array[i]); 
}
