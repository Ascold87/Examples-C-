// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData1(string msg)
{
    Console.WriteLine(msg);
}

void PrintData2(string msg)
{
    Console.WriteLine(msg);
}

void Numbers(int A)
{
    while (A > 0)
    {
        Console.WriteLine(A);
        Numbers(A - 1);
        break;
    }
}

PrintData1("Программа, вычисляет и выводит в столбик все натуральные числа в промежутке от N до 1.");
int N = ReadData("Задайте значение N: ");
PrintData2($"Натуральные числа в промежутке от {N} до 1: ");
Numbers(N);
