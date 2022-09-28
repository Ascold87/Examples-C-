// Кандомайзер массива из 0 и 1 заданной длинной

int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

int[] Fill1DArr(int len, int lowBord, int highBord)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new System.Random().Next(lowBord, highBord + 1);
    }
    return array;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");
int[] arr = Fill1DArr(arrLen, 0, 1);
Print1DArr(arr);

