// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt (int num)
{
    if (num <= 0) num = num*-1;
    int y = num/10;
    int z = y%10;
        if (99 < num && num < 999)
        {
        Console.WriteLine(z);
        }
        else
        {
            Console.WriteLine("Число не является трёхзначным");
        }
    return z;
}

Console.Clear();
Console.WriteLine("Введите трёхзначное число ");
int number = int.Parse(Console.ReadLine()!);
int result = Prompt (number);