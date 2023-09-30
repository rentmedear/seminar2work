// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёх значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int firstnum = num % 100;
// int snum = firstnum / 10;
// Console.WriteLine($"вторая цифра числа-> {snum}");
int DeleteFirstAndLastDigit (int number)
{
    int firstnum = num % 100;
    int snum = firstnum / 10;
    return firstnum / 10;
}
int res = DeleteFirstAndLastDigit(num);
Console.WriteLine($"{num} -> {res}");
//работает только с трёхзначными числами
// у чисел больше 999 показывает третье цисло с конца
// у чисел меньше 100 показывает первое число
//  по условию задачи программа создана только для трёхзначных чисел