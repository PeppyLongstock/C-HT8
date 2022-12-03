﻿/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5-> "5, 4, 3, 2, 1"
N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Enter a positive integer larger than 1:");
int number = Convert.ToInt32(Console.ReadLine());

void NumberCounter(int number)
{
    if (number < 0) Console.WriteLine($"{number} not a natural number");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter(number - 1);
}

NumberCounter(number);