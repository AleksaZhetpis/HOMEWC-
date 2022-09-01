/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int num1, num2;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Max = " + num1);
}

if (num1 < num2)
{
    Console.Write("Max = " + num2);
}
*/



/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int num1, num2, num3;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Max = " + num1);
}

if (num1 < num2)
{
    Console.Write("Max = " + num2);
}

if (num1 > num3)
{
    Console.Write("Max = " + num1);
}

if (num1 < num3)
{
    Console.Write("Max = " + num3);
}
*/



/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


int num;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());



if (num % 2 == 0)
{
    Console.Write("Четное " + num);
}

else
{
    Console.Write("Нечетное " + num);
}
*/


/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n, current;

Console.Write("Input a number from 1: ");
n = Convert.ToInt32(Console.ReadLine());

n = n + 2;

current = n / (2);

while (current <= n)
{
   Console.Write(current + " ");
   current = current + 2;
}
*/

