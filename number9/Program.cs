// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


Random rnd = new Random();
int value = rnd.Next(10, 99);
Console.WriteLine(value); 
int a = 0;
int b = 0;
a = value / 10; //1 цифра
b = value % 10; //2 цифра
if(a > b)
{
  Console.WriteLine("Наибольшая цифра числа {0}", a);
}
else
{
  Console.WriteLine("Наибольшая цифра числа {0}", b);    
}