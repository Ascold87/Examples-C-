// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData1(string msg)
{
    Console.WriteLine(msg);
}


void PrintData2(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int Ackerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    if (a > 0 && b == 0)
    {
        return Ackerman(a - 1, 1);
    }
    return Ackerman(a - 1, Ackerman(a, b - 1));
}

PrintData1("Программа вычисляет функцию Аккермана методом рекурсии.");
int m = ReadData("Введите натуральное положительное число M: ");
if (m < 1)
{
    m = 0;
    Console.WriteLine("Введено неверное значение, принимается, как  M = 0");
}
int n = ReadData("Введите натуральное число N: ");
if (n < 1)
{
    n = 0;
    Console.WriteLine("Введено неверное значение, принимается, как N = 0");
}
int result = Ackerman(m, n);
PrintData2($"A(m,n) = ", result);
