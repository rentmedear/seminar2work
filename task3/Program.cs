// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num > 1000)
{
      num = num / 10;
}
int tnumber = num % 10;
if (num < 101) Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"третья цифра-> {tnumber}");
