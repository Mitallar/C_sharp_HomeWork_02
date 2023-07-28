// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (int num)
{
    if (0 < num && num < 8)
        {
        if (0 < num && num < 6) Console.WriteLine("Нет");
        else Console.WriteLine("Да");
        }
    else Console.WriteLine("Цифра не соответствует дням недели");
    return num;
}

Console.Clear();
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int result = Prompt(x);