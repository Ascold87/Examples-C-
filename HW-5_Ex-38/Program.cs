// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadData(string msg) 
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] Fill1DArray(int length, int lowBord, int highBord)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(lowBord, highBord + 1);
    }
    return array;
}

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

void PrintDiff(int[] array)
{
    int diff = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    Console.WriteLine(diff);
}

int arrayLength = ReadData("Введите длину массива: ");
int min = new Random().Next(1, 10);
int max = new Random().Next(10, 100);
int[] array = Fill1DArray(arrayLength, min, max);
Print1DArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементов массива: ");
PrintDiff(array);