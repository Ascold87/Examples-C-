// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintData(string msg, string averages)
{
    Console.WriteLine(msg + averages);
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
            Console.Write("{0,3}", $"{matrixNew[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

string Average(int[,] getMatrix, int row, int column)
{
    double sum = 0;
    double average = 0;
    string result = string.Empty;
    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < column; i++)
        {
            sum += getMatrix[i, j];
        }
        average = sum / row;
        average = Math.Round(average, 1);
        if (j != row - 1) result += $"{average.ToString()}; ";
        else result += $"{average.ToString()}. ";
        // result += String.Join("", $"{average.ToString()}; "); - первое решение.
        average = 0;
        sum = 0;
    }
    return result;
}

int y = new Random().Next(3, 10);
int x = new Random().Next(4, 10);
int[,] matrix = new int[y, x];
FillArray(matrix);
PrintArray(matrix);
PrintData("Создан случайный двумерный массив. Среднее арифметическое каждого столбца: ", Average(matrix, x, y));
