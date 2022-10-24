// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = a1 * x + b1, y = a2 * x + b2; значения b1, а1, b2 и а2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, string point)
{
    Console.WriteLine(msg + point);
}

string IntersectionPoint(double numA1, double numB1, double numA2, double numB2)
{
    double x = ((numB2 - numB1) / (numA1 - numA2));
    double y = (numA1 * ((numB2 - numB1) / (numA1 - numA2)) + numB1);
    return $"({x}; {y})";
}

int numA1 = ReadData("Поиск точки пересечения двух прямых, заданных функциями [y1 = a1 * x + b1] и [y2 = a2 * x + b2]. Введите первую точку первого отрезка (а1): ");
int numB1 = ReadData("Введите вторую точку первого отрезка (b1): ");
int numA2 = ReadData("Введите первую точку второго отрезка (а2): ");
int numB2 = ReadData("Введите вторую точку второго отрезка (b2): ");

string point = IntersectionPoint(numA1, numB1, numA2, numB2);
PrintData("Точка пересечения двух прямых находится в координатах ", point);
