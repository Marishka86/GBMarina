﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int MiddleNum(int num)
{
    int mid = num % 100 /10;
    return mid;
}
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int middle = MiddleNum(num);
Console.Write("Вторая цифра трёхзначного числа - " + middle);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNum(int num)
{
    if(num < 100)
    {
        return -1;
    }
    if(num > 999)
    {
        while(num > 999)
        {
            num = num / 10;
        }
    }
    
    int thirdNum = num % 10;
    return thirdNum;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = ThirdNum(num);
if(result < 0)
{
    Console.WriteLine($"В числе {num} нет третьей цифры.");
}
else
{
    Console.WriteLine($"Третья цифра числа {num} - {result}.");
}
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Введите день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

bool CheckDay(int num)
{

    if (num == 6 || num == 7) 
    {
        Console.WriteLine("Ответ: Выходной день.");
        return true;
    }
    else if  (num < 1 || num > 7)
    {
        Console.WriteLine("Ошибка: В неделе всего 7 дней!");
        return false;
    }
    else
    {
        Console.WriteLine("Ответ: Будний день.");
        return false;
    }
}


bool day = CheckDay(dayOfWeek);
Console.WriteLine(day);
*/

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int number)
{
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;
        if (nul < 1 || nul > 9)
        {
            Console.WriteLine(number + " -> " + "Не пятизначное число");
        }
        else if (num1 == rev2 && num2 == rev1)
        {
            Console.WriteLine(number + " -> " + "Да, это палиндром!");
        }
        else
        {
            Console.WriteLine(number + " -> " + "Нет, это не палиндром!");
        } 
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

