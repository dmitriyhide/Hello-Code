﻿// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number / 100;
int number2 = number / 10;

Console.WriteLine($"Вывод второй цифры числа {number2 % 10}");