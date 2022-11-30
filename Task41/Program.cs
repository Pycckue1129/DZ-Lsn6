using System;
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите числа через пробел: ");
var nums = Console.ReadLine();
int[] array = nums.Split(' ').Select(Int32.Parse).ToArray();
int numsBiggerZero = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        numsBiggerZero++;
    }
}


System.Console.WriteLine(numsBiggerZero);