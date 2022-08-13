﻿// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int n = ReadInt("Введите число: ");
int count = 1;

while (count < n + 1)
{
    Console.Write($"{count * count * count} ");
    count++;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}