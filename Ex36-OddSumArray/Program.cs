/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int InputArrayLength(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

int SumOddInArray(int[] array)
{
    int oddSum = default;
    int i = 1;
    while(i < array.Length)
    {
        oddSum += array[i];
        i += 2;
    }
    return oddSum;
}

int arrLeng = InputArrayLength("Введите длину массива: ");
int[] arr = GenerateArray(arrLeng);
PrintArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOddInArray(arr)}.");