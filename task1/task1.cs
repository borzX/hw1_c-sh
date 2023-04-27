/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число:");
int a_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b_num = Convert.ToInt32(Console.ReadLine());
if (a_num>b_num)
{
Console.WriteLine("Первое число " + a_num + " больше, чем второе число " + b_num);

}
else Console.WriteLine("Второе число " + b_num + " больше, чем первое число " + a_num);
