// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Программа принимает число, а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число.");

int user_A = int.Parse(Console.ReadLine());
int X = 1;

Console.WriteLine("Далее аредставлены все четные числа от 1, до " + user_A + " .");
while (X < user_A)
{
    if (X % 2 == 0)
    {
        Console.Write(X + ", ");
    }
    X = X + 1;
}
Console.WriteLine("Конец.");