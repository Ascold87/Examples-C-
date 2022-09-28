// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// создаёт строчку от 1 до N(+i) и вторую от 1 до N^3(+i^3)
string LineNumbersPow(int numberN, int pow)
{
    int i = 1;
    string line = "";
    string outLine = string.Empty;
    while (i <= numberN)
    {
        line = line+" "+Math.Pow(i, pow);

        //Console.Write("{0,7}" ,Math.Pow(i, pow));
        i++;
    }
    //Console.WriteLine();
    return line;
}
int num = ReadData("Введите число N: ");


string line1 = LineNumbersPow(num, 1);
string line2 = LineNumbersPow(num, 3);

Console.WriteLine(line1);
Console.WriteLine(line2);
