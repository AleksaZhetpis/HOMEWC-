// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив: 
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив: 
//1 2 4 7
//2 3 5 9
//2 4 4 8

/*int m = Number("Введите m: ");
int n = Number("Введите n: ");
int range = Number("Введите от 1 до ");

int[,] array = new int[m, n];
Array3(array);
Array2(array);

Console.WriteLine($"\nУпорядоченные по убыванию элементы: ");
Array1(array);
Array2(array);

void Array1(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int Number(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void Array3(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void Array2(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int m = Numbers("Введите m: ");
int n = Numbers("Введите n: ");
int range = Numbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
Array1(array);
Array2(array);

int min = 0;
int sum = Sum2(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int Sum = Sum2(array, i);
  if (sum > Sum)
  {
    sum = Sum;
    min = i;
  }
}

Console.WriteLine($"\n{min+1} - строкa с наименьшей суммой ({sum}) элементов ");


int Sum2(int[,] array, int i)
{
  int sum2 = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum2 += array[i,j];
  }
  return sum2;
}

int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void Array1(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void Array2 (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/


//Задача 62. Заполните спирально массив 4 на 4. Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

/*int A = 4;
int[,] Massiv = new int[A, A];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Massiv.GetLength(0) * Massiv.GetLength(1))
{
  Massiv[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Massiv.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Massiv.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Massiv.GetLength(1) - 1)
    j--;
  else
    i--;
}

Array(Massiv);

void Array (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/
