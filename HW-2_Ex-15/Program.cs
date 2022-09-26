// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели (от 1 до 7) : ");
int user_number = int.Parse(Console.ReadLine());
if (user_number < 0)
{
    Console.Write("Это не то число");
}
else if(user_number > 8)
{
    Console.Write("Это не день недели");
}
else if(user_number == 7)
{
    Console.WriteLine("Воскресение - это выходной"); 
}
else if(user_number == 6)
{
    Console.WriteLine("Суббота - это выходной"); 
}
else
{
    Console.WriteLine("Это будний день."); 
}
