﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Программа принимает на ввод число и выдает сумму цифр в числе.");
Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
int GetSumNums(int number)
{
    int sum =0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}