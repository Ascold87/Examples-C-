// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int DigitCount(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num /= 10;
    }
    return result;
}
int num = ReadData("Введите натуральное число: ");
int sum = DigitCount(num);
PrintData($"Сумма всех чисел в числе {num} равна ", sum);