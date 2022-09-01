// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*Console.WriteLine("Введите размер массива: ");
int arraysize = Convert.ToInt32(Console.ReadLine());

int[] num = new int[arraysize];

FillArrayRandomNumbers(num);
Console.WriteLine("Массив: ");

PrintArray(num);
int count = 0;

for (int A = 0; A < num.Length; A++)
if (num[A] % 2 == 0)
count++;

Console.WriteLine($"В массиве {num.Length} чисел, чётные: {count}");

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Array(numbers);
Console.WriteLine("Массив: ");
Array2(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"Всего чисел {numbers.Length}, сумма элементов на нечётных позициях = {sum}");

void Array(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void Array2(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
 */


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


/*Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
Array(numbers);
Console.WriteLine("Mассив: ");

Array2(numbers);
double Min = Int32.MaxValue;
double Max = Int32.MinValue;

for (int A = 0; A < numbers.Length; A++)
{
    if (numbers[A] > Max)
        {
            Max = numbers[A];
        }
    if (numbers[A] < Min)
        {
            Min = numbers[A];
        }
}

Console.WriteLine($"Всего чисел {numbers.Length}. Максимальное = {Max}, минимальное = {Min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {Max - Min}");

void Array(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void Array2(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/
