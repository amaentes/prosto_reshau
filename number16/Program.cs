// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int a;
int b;
Console.WriteLine("Введите два числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a * a == b || b * b == a)
{
  Console.WriteLine("Число является квадратом другого");
}
else
{
  Console.WriteLine("Число не является квадратом другого");
}