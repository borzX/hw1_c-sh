﻿/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число:");
int a_num = Convert.ToInt32(Console.ReadLine());
int num_start = 2;
while (num_start<=a_num)
{
    Console.Write(num_start);
    Console.Write(", ");
    num_start = num_start+2;
}