﻿Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    Console.Write("Кратное число");
}
else
{
    Console.WriteLine("Не кратное число");
    Console.WriteLine("Остаток = " + a % b);
}

