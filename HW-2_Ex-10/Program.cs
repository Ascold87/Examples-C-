﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int user_number = int.Parse(Console.ReadLine());
int result = ((user_number / 10) % 10);
Console.WriteLine("Вторая цифра: " + result);