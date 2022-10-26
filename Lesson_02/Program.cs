/* Домашнее задание к семинару № 2. Массивы и функции в программировании.
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
    и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
*/

/*
int Num(int num)
{
    int result;

    int hund = num % 100;
    int dec = hund / 10;
    result = dec;

    return result;
}

int number = new Random().Next(100, 1000);
Console.WriteLine("Сгенерированное трехзначное число: " + number);
int number2 = Num(number);
Console.WriteLine($"Вторая цифра числа {number}: число {number2}");
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int ThirdNumber(int num)
{
    int result = 0;

    if (num < 100)
        Console.WriteLine("Третья цифра отсутствует");        
    else
    {
        while (num >= 1000)
        {
            num /= 10;
        }
        if (num >= 100 && num < 1000)
        {
            int ed = num % 10;
            result = ed;            
        }          
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = ThirdNumber(number);
Console.WriteLine($"Третья цифра числа {number} - цифра '{number2}'");
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
int DayWeek(int num)
{
    int result = num;

    if (num >= 8)
    {
        Console.WriteLine("Неверный ввод! Число должны быть в диапазоне от 1 до 7!");
    }
    else
    {
        if (num == 6 || num == 7)
        {
            Console.WriteLine($"День недели под цифрой '{num}' - выходной день");
        }
        else
        {
            Console.WriteLine($"День недели под цифрой '{num}' - рабочий день");
        }
    }
    return result;
}

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32((Console.ReadLine()));

Console.WriteLine(DayWeek(number));
*/