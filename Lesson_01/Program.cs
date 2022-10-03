/* Домашнее задание к семинару № 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Максимальное число: {a}");
}
else
{
    Console.WriteLine($"Максимальное число: {b}");
}
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное из трех введенных чисел: ");
Console.WriteLine(max);
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine($"Число {n} - чётное");
}
else{
    Console.WriteLine($"Число {n} - нечётное");
}
*/

/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 2;

if(n <= 1)
{
    Console.WriteLine("Неверный ввод");
}

while(current <= n)
{
    Console.Write(current + ", ");
    current = current + 2;
}
*/