// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Calculator(double numA, double numB)
{
    double result = 0;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}