/* Домашнее задание к уроку № 4. 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine("число " + a + ", возведенное в степень " + b + " = " + result);
}

int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите второе число: ");
Degree(num1, num2);
*/

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void NumbersSum(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр равна {sum}");
}

int ReadInt(string messages)
{
    Console.Write(messages);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");
int len = NumberLength(number);
NumbersSum(number, len);
*/

/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
m = 5 -> [1, 2, 5, 7, 19]
m = 3 -> [6, 1, 33]
*/

/*
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string messages)
{
    Console.Write(messages);
    return Convert.ToInt32(Console.ReadLine());
}
*/