// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine($"Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
Console.Write("Введите строку элемента: ");
int i = Convert.ToInt32(Console.ReadLine())-1;
Console.Write("Введите введите позицию элемента в строке: ");
int j = Convert.ToInt32(Console.ReadLine())-1;
Console.WriteLine();
Console.WriteLine(SearchArray(i,j,array));

void CreateArrayDouble(double[,] array) //Функция заполнения массива
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array) //Функция вывода массива
{
Console.Clear();
Console.WriteLine("Сгенерирован следующий массив");
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
string SearchArray(int i,int j, double[,] array)//Поиск элемента
{
  if ((array.GetLength(0)<i)^(array.GetLength(1)<j))
    return "Такого значения нет";
    else
    {
      return Convert.ToString(Math.Round(array[i, j], 1));
    }
}