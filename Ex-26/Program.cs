int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigitOneToA(int numA)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum = sum + i;
        //sum += i;
    }
    return sum;
}

int GaussMethod(int numA)
{
    int sum = ((1 + numA) * numA) / 2;
    return sum;
}
Console.WriteLine(DateTime.Now-d1);

PrintData("Сумма чисел от 1 до А(simple): ", sum);

DateTime d2 = DateTime.Now;
int sumGaus = GaussMethod(numA);
Console.WriteLine(DateTime.Now-d2);

PrintData("Сумма чисел от 1 до А(gausse): ", sumGaus);
От Valentine Kononov всем 09:03 PM
Math
скинуть
countDigitNum(num));

int CountDigitNum(int num)
{
    int count = 0;
    while(num>0)
    {
        num = num/10;
        count++;
    }
    return count;
}


int CountDigitString(int num)
{
    if (num > 0)
    {
        return num.ToString().Length;
    }
    else
    {
        return num.ToString().Length - 1;
    }
}
