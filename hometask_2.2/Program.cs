﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(int num)
{
if (num < 100) Console.WriteLine("Третьей цифры нет");
else while (num > 999) num = num/10;
return (num%10);
}

Console.Clear();
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int result = Prompt(x);
Console.WriteLine(result);