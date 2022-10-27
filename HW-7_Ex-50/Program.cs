// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> число с таким адресом в массиве нет

string ReadData(string msg)
{
    Console.Write(msg);
    string numbers = Console.ReadLine() ?? "0";
    return numbers;
}

void PrintData(string msg, int value)
{
    if (value == 0) Console.WriteLine(msg);
    else Console.WriteLine(msg + value);
}

void FillArray(int[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = new Random().Next(-9, 10);
        }
    }
}

void PrintArray(int[,] matrixNew)
{
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

string index = ReadData("Введите через пробел строку и столбец изкомой цифры: ");
int y = new Random().Next(3, 10);
int x = new Random().Next(4, 10);
int[,] matrix = new int[y, x];
FillArray(matrix);
PrintArray(matrix);
string[] array = index.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
int yNew = int.Parse(array[0]);
int xNew = int.Parse(array[1]);

if (yNew < y && xNew < x)
{
    PrintData("Выбранное число массива: ", matrix[yNew, xNew]);
}
else
{
    int q = 0;
    PrintData("Введенные координаты неверны. В массиве отсутствует адрес.", q);
}
