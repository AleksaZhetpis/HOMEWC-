/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void CutNumberVoid()

{
Console.Write("Input a number from 10000 to 100000: ");
int num = Convert.ToInt32(Console.ReadLine());

    int num1 = num / 10000; 
    int num2 = num % 10;

    if (num1 == num2)
    {
     Console.WriteLine("Палиандром");
    } 
    else
    {
      Console.WriteLine("Не Палиандром");  
    }  

}   

CutNumberVoid();
*/

/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Quad(int x)
{
    int current = 1;
    while (current <=x)
    {
        int quad = current * current * current;
        Console.Write(quad + " ");
        current++;
    }

}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Quad(n);
*/

