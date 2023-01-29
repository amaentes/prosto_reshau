// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine(value); 
int a;
int b;
int c;
a = value / 100; //1 цифра
b = value % 100 / 10; //2 цифра
c = value % 10; // 3 цифра
Console.WriteLine("Итоговое число {0}{1}", a, c);

