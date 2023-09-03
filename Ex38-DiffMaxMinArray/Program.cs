/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

int InputArrayLength(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}

double[] GenerateArray(int length)
{
    double[] result = new double[length];
    var rand = new Random();
    for (int i = 0; i < length; i++)
    {
        result[i] = Math.Round(rand.NextDouble() * 99, 2);
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

double DiffMaxMinArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double difference = default;
    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }

        if(min > array[i])
        {
            min = array[i];
        }
    }
    return difference = Math.Round(max - min, 2);
}

int arrLeng = InputArrayLength("Введите длину массива: ");
double[] arr = GenerateArray(arrLeng);
PrintArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMaxMinArray(arr)}.");