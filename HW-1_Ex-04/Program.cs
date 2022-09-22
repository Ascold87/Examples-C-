// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа. Посмотрим, какое из них больше?");
Console.WriteLine("Введите первое число");
int user_A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int user_B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int user_C = int.Parse(Console.ReadLine());
int max = user_A;

if (user_B > max)
{
    max = user_B;
}
if (user_C > max)
{
    max = user_C;
}

Console.Write("Большее число - " + max);
