// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа. Посмотрим, какое из них больше?");
Console.WriteLine("Введите первое число");
int user_a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int user_b = int.Parse(Console.ReadLine());

if (user_a > user_b)
{
    Console.Write("Компьютер говорит, что " + user_a);
    Console.WriteLine(" больше " + user_b);
}
else if (user_a < user_b)
{
    Console.Write("Компьютер говорит, что " + user_b);
    Console.WriteLine(" больше " + user_a);
}
else
{
    Console.WriteLine("Компьютер говорит, что числа равны");
}
Console.WriteLine("Спасибо за внимание и удачи!");