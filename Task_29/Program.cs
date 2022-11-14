// Задача 29
// Напишите программу, которая 
// 1. Задаёт массив из 8 элементов и 
// 2. Выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int sizeDigit = 8; 

int[] SizeArray(int size)
{
    int[] array = new int[size]; //
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] sizeArray = SizeArray(sizeDigit);
Console.WriteLine("Массива из 8 элементов заполненный случайными числами : ");
PrintArray(sizeArray);

