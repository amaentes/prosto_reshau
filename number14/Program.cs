﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 & a % 23 == 0)
{
  Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
  Console.WriteLine("Число не кратно одновременно 7 и 23");
}