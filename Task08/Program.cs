﻿// Напишите программу, 
// 1. которая на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

if(number > 1)
{
    while(i <= number)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}