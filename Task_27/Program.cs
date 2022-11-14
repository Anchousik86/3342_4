// Задача 27
// Напишите программу, которая 
// 1. Принимает на вход число и 
// 2. Выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int number)
{
    int sum = 0;
    while (number >= 1)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumNumbers}");