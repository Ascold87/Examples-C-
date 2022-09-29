// №23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число, до которого необходимо вычислить ряд кубов: ");
int user_num = int.Parse(Console.ReadLine());
if (user_num > 0)
{
    Console.WriteLine("Список кубов до " + user_num + "го, в строку.");
    for (int a = 1; a <= user_num; a++)
    {
        Console.Write(Math.Pow(a, 3) + ". ");
    }
}
else
{
    Console.WriteLine("Неверное число");
}