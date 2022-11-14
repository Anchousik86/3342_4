// Задача 25
// Напишите цикл, который принимает 
// 1. На вход два числа (A и B) и 
// 2. Возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Write("Введите основание степени: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (num > 0 && degree > 0)
{
    int numDegree = Exponentiation(num, degree);
    Console.WriteLine($"Основание {num} возведенное в степень {degree} = {numDegree}");
}
else
{
    Console.WriteLine("Введены не корректные данные");
}


int Exponentiation(int number, int degree_)
{
    int result = number;
    for (int i = 1; i < degree_; i++)
    {
        result *= number;
    }
    return result;
}