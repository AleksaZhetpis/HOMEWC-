/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber()

{
Console.Write("Input a number from 100 to 1000: ");
int num = Convert.ToInt32(Console.ReadLine());

    int num1 = num / 10;
    int num2 = num % 10;    
    
return num/10%10;   
     
}  

int number = CutNumber();
Console.WriteLine("Result number is " + number);
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int CutNumber()

{
Console.Write("Input a number from 1 to 1000: ");
int num = Convert.ToInt32(Console.ReadLine());

    int num1 = num / 1000;
    int num2 = num % 10;    

if (num < 100)
{
    Console.WriteLine("Third number is absent");
}
int result = num1 * 100 + num2;
return result;
    
}  

int number = CutNumber();
Console.WriteLine("Result number is " + number);
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int day;
Console.Write("Введите число дня недели от 1 до 7: ");
day = Convert.ToInt32(Console.ReadLine());
if(day == 1)
{
  Console.WriteLine("Рабочий день");
}
if(day == 2)
{
  Console.WriteLine("Рабочий день");
}
if(day == 3)
{
  Console.WriteLine("Рабочий день");
}
if(day == 4)
{
  Console.WriteLine("Рабочий день");
}
if(day == 5)
{
  Console.WriteLine("Рабочий день");
}
if(day == 6)
{
  Console.WriteLine("Выходной день");
}
if(day == 7)
{
  Console.WriteLine("Выходной день");
}
if(day > 7 || day < 1)
{
  Console.WriteLine("Такого дня недели не существует.");
}
*/
