// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string ReadData(string msg)
{
    Console.Write(msg);
    string numbers = Console.ReadLine() ?? "0";
    return numbers;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

string numbers = ReadData("Введите с клавиатуры через пробел нескольео чисел: ");
string[] array = numbers.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
int count = 0;
foreach (var item in array)
{
    if (int.Parse(item) > 0) count++;
}
PrintData($"Количество цифр больше нуля = ", count);