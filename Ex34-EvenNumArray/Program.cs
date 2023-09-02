/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2 */



int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 999);
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

int InputArrayLength(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

int EventNumInArray(int[] array)
{
    int eventIndex = default;
    for(int i = 0; i < array.Length;i++)
    {
        int eventCheck = array[i] % 2;
        if(eventCheck == 0)
        {
            eventIndex ++;
        }
    }
    return eventIndex;
}

int arrLeng = InputArrayLength("Введите длину массива: ");
int[] arr = GenerateArray(arrLeng);
PrintArray(arr);
Console.WriteLine($"Количество четных чисел массива равно {EventNumInArray(arr)}.");