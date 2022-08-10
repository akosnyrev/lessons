int[] point1= new int[3];
int[] point2= new int[3];
Console.Clear();
Console.WriteLine("Давайте определим расстояние между точками в пространстве по их координатам.");
Console.WriteLine("Последовательно введите координаты первой точки:");

for (int i=0;i<3;i++)
    {
        Console.WriteLine("Введите координату {0:G}\n",i+1);
        point1[i]=Convert.ToInt32(Console.ReadLine()); 
    }
Console.Clear();
Console.WriteLine("Последовательно введите координаты второй точки:");

for (int i=0;i<3;i++)
    {
        Console.WriteLine("Введите координату {0:G}\n",i+1);
        point1[i]=Convert.ToInt32(Console.ReadLine()); 
    }
double[] pow2= new double[3];
for (int i=0;i<3;i++)
    {
        pow2[i]= Math.Pow( Convert.ToDouble(point1[i]-point2[i]),2);
    }
Console.Clear();
Console.WriteLine("Расстояние между точками составляет:");
Console.WriteLine("{0:0.00}",Math.Sqrt(pow2[0]+pow2[1]+pow2[2]));
