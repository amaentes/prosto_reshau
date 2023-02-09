// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] array = GetRandomArray(6, -9, 9);
// int[] minAndMax = ChandeNumbersMarks(array);
// Console.WriteLine($"Введен массив {string.Join("", array)}");
// Console.WriteLine($"Замененный массив {string.Join("", ChandeNumbersMarks(array))}");

// int [] GetRandomArray(int length, int min, int max)
// {
//     int[] array = new int [length];
//     Random num = new Random();

//     for (int counter = 0; counter < length; counter++)
//     {
//         array[counter] = num.Next(min, max + 1);
//     }
//     return array;

// }

// int [] ChandeNumbersMarks(int[] array)
// {
//     int[] newArray = new int [array.Length];

//     for(int counter = 0; counter < array.Length; counter++)
//     {
//         newArray[counter] = array[counter] * -1;
//     }
//     return newArray;
// }

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] array = GetRandomArray(12, -9, 9);
// int number;
// Console.WriteLine("Введите число");
// number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введен массив {string.Join("", array)}");
// ChandeNumbersMarks(array);

// int[] GetRandomArray(int length, int min, int max)
// {
//     int[] array = new int[length];
//     Random num = new Random();

//     for (int counter = 0; counter < length; counter++)
//     {
//         array[counter] = num.Next(min, max + 1);
//     }
//     return array;
// }

// void ChandeNumbersMarks(int[] array)
// {

//         for (int counter = 0; counter < array.Length; counter++)
//         {
//             if(array[counter] == number)
//             {
//                 Console.WriteLine("Есть такое число");
//                 return;
//             }
//         }
//         Console.WriteLine("Такого числа нет");
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] array = GetRandomArray(123, -150, 150);
// // int number;
// // Console.WriteLine("Введите число");
// // number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введен массив {string.Join(", ", array)}");
// Console.WriteLine(ChandeNumbersMarks(array));
// // ChandeNumbersMarks(array);


// int[] GetRandomArray(int length, int min, int max)
// {
//     int[] array = new int[length];
//     Random num = new Random();

//     for (int counter = 0; counter < length; counter++)
//     {
//         array[counter] = num.Next(min, max + 1);
//     }
//     return array;
// }

// int ChandeNumbersMarks(int[] array)
// {
//         int sum = 0;
//         for (int counter = 0; counter < array.Length; counter++)
//         {
//             if(array[counter] >= 10 && array[counter] <=99)
//             {
//                 sum++;
//             }
//         }
//         return sum;
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = GetRandomArray(6, -99, 99);
// int number;
// Console.WriteLine("Введите число");
// number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введен массив {string.Join(", ", array)}");
ChandeNumbersMarks(array);
// ChandeNumbersMarks(array);

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random num = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;
}

void ChandeNumbersMarks(int[] array)
{
        int a = 0;
        int b = array.Length;
        for (int i = 0; i < (array.Length)/2; i++)
        {
            a = array[i] * array[b - 1 - i];
            Console.WriteLine(a);
        }
        if(b % 2 != 0)
        {
            Console.WriteLine(array[b/2]);
        }
}