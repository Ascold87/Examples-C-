// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
int user_number = int.Parse(Console.ReadLine());
if (user_number < 99)
{
    Console.Write("Это не трехзначное число");
}
else if(user_number > 1000)
{
    Console.Write("Это не трехзначное число");
}
else
{
    int result = ((user_number / 100) % 10);
Console.WriteLine("Третья цифра: " + result); 
}