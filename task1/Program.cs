int number = new Random().Next(10,100);
Console.WriteLine($"случайное число из отрезка [10,99]-> {number}");

// int firstdigit = number / 10;
// int secondigit = number % 10;

// if(firstdigit > secondigit)
// Console.WriteLine($"наибольшай цифра цисла [10,99]-> {firstdigit}");
// else
// {
//    Console.WriteLine($"наибольшай цифра числа {number} -> {secondigit}");
// }
// int maxdigit = firstdigit > secondigit ? firstdigit : secondigit;
//Console.WriteLine($"наибольшай цифра числа {number} -> {maxdigit}");

int maxdigit = MaxDigit (number);
Console.WriteLine($"наибольшай цифра числа {number} -> {maxdigit}");
int MaxDigit (int num)
{
    int firstdigit = num / 10;
    int secondigit = num % 10;
    return firstdigit > secondigit ? firstdigit : secondigit;


}