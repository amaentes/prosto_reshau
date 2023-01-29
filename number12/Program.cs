// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int a;
int b;
int remains = 0;
Console.WriteLine("Введите сначала число а, потом b");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
remains = a % b;
if (a == 0)
{
    Console.WriteLine("Кратно");
}
else if (a < b)
{
    Console.WriteLine("Вы ввели первое число меньше второго, запусите программу заново и введите первое число, которое будет больше второго");
}
else if (a % b == 0)
{
    Console.WriteLine("Кратно");
}
else if (remains % 1 == 0)
{
    Console.WriteLine("Не кратно, остаток {0}", remains);
}
