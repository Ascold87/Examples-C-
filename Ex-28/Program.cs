// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.



int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, long value)
{
    System.Console.WriteLine(msg + value);
}

long Fuktor(int num)
{
    long res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}

int numN = ReadData("Введите число N: ");
long outResult = Fuktor(numN);
PrintData("Фкториал числа " + numN + " равен: ", outResult);
