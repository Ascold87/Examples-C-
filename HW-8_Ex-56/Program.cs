// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

void FillArray(int[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrixNew)
{
    Console.WriteLine();
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"{matrixNew[i, j]} ");
            else Console.Write("{0,3}", $"{matrixNew[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SelectionNum(int[,] array)
{
    int num = 0;
    int max = 0;
    int min = 0;
    int[] minRow = new int[0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sum = sum + array[i, j];
        }
        Array.Resize(ref minRow, minRow.Length + 1);
        minRow[minRow.Length - 1] = sum;
    }

    for (int k = 0; k < minRow.Length; k++) 
    {
        if (minRow[k] > max) max = minRow[k];
        min = minRow[k];
    }

    for (int h = 0; h < minRow.Length; h++) 
    {
        if (minRow[h] < min) min = minRow[h];
    }

    while (num < minRow.Length)
    {
        if (minRow[num] == min)
        {
            num++;
            break;
        }
        num++;
    }

    return num;
}

int y = new Random().Next(4, 10);
int x = new Random().Next(3, 10);
while (y == x)
{
    x = new Random().Next(4, 10);
}
int[,] matrix = new int[y, x];
PrintData("");
PrintData("Программа создает случайный двумерный масств:");
FillArray(matrix);
PrintArray(matrix);
PrintData($"Формат матрицы: {y} строк на {x} столбцов.");
PrintData($"Строка с наименьшей суммой элементов: {SelectionNum(matrix)}-я.");
