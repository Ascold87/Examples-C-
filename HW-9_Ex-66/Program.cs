// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData1(string msg, int res)
{
    Console.WriteLine(msg + res);
}

void PrintData2(string msg)
{
    Console.WriteLine(msg);
}

int Numbers(int A, int B)
{
    int sum = 0;
    if (A > B)
    {
        int a = (A * (A + 1)) / 2;
        int b = (B * (B + 1)) / 2;
        sum = a - b + B;
        return sum;
    }
    else
    {
        int a = (B * (B + 1)) / 2;
        int b = (A * (A + 1)) / 2;
        sum = a - b + A;
        return sum;
    }
}

PrintData2("Программа вычисляет сумму всех натуральных чисел в интервале от M до N.");
int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");
int result = Numbers(M, N);
PrintData1($"Сумма всех натуральных чисел в интервале от {M} до {N}: ", result);
