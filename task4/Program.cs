// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7) Console.WriteLine("Введите число от 1 до 7!!");
if (num < 6) Console.WriteLine($"{num} -> нет");
if (num == 6) Console.WriteLine($"{num} -> да");
if (num == 7) Console.WriteLine($"{num} -> да");