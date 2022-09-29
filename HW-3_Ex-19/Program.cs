// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int user_number(int num, int NumberOfFirstNumbers)
{
    while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
    {
        num /= 10;
    }
    return num;
}

Console.Write("Введите 5ти-значное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int x = number % 100;
    int y = user_number(number, 2);

    if (x / 10 == y % 10 && x % 10 == y / 10)
    {
        Console.WriteLine("Это число - палидром.");
    }
    else
    {
        Console.WriteLine("Это число - не палидром.");
    }
}
else
{
    Console.WriteLine("Неверное число.");
}