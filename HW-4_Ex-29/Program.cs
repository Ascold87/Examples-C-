// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int lowest, int highest)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(lowest, highest + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(array[array.Length - 1] + "]");
}
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");
int[] array = FillArray(min, max);
PrintArray(array);