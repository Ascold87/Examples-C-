// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число.");
int user_A = int.Parse(Console.ReadLine());

if (user_A % 2 == 0)
{
    Console.Write("user_A");
    Console.WriteLine(" - Четное.");
}
else
{
    Console.Write("user_A");
    Console.WriteLine(" - Нечетное.");
}

