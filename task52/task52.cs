
// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine($"Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое столбцов: ");
int x=0;
while (x<array.GetLength(0))
  {
    Console.Write($" {Math.Round(ArithmeticMean(x,array),1)}");
    x++;
  }

//Функции
void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

double ArithmeticMean(int i,double[,] array)
{double am=0;
int j=0;
while (j<array.GetLength(1))
  {
    am=am+array[i,j];
    j++;
  }
  am=am/array.GetLength(1);
  return am;

}