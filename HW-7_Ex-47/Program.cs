// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void FillArray(double[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 11), 1);
        }
    }
}

void PrintArray(double[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            Console.Write("{0,5}", $"{matrixNew[i, j]} ");
        }
        Console.WriteLine();
    }
}

int y = ReadData("Программа создаёт двумерный массив, заполненный случайными вещественными числами. Введите число строк массива: ");
int x = ReadData("Введите число столбцов массива: ");
double[,] matrix = new double[y, x];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
