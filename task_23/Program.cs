﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int f, count = 1;
while (count <= a)
{
  f = count * count * count;
  {
    Console.Write($" {f}.");
  }
  count++;
}