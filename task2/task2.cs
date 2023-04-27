/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число:");
int a_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int c_num = Convert.ToInt32(Console.ReadLine());
int max = a_num;
if (b_num>max)
{
    max = b_num;
}
if (c_num>max)
{
    max = c_num;
}
Console.WriteLine($"max = {max}");
