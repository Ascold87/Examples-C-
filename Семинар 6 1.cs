using System;
using System.Linq;
// string words = Console.ReadLine();
// Console.WriteLine(words);
// string[] nums = words.Split(",");
// int index = new Random().Next(0,nums.Length);
// Console.WriteLine(nums[index]);
// Console.WriteLine(String.Join(" ",nums));
/* Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.*/
int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
int[] NumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;
    }
    return array;
}
bool FindNumber(int number, int[] array)
{
    // foreach (var item in array)
    // {
    //     if(item == number) 
    //     {
    //         return true;
    //     }
    // }
    // return false;
    return array.Contains(number);
}
int[] DO(int[] array, int min, int max)
{
    int[] coint = new int[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > min && array[i] < max){
            coint[index] = array[i];
            index++;
        }
    }
    return coint;
}
int[] array = CreatorArray(8,-10,11);
Console.WriteLine(String.Join(" ",array));
Console.WriteLine(String.Join(" ",DO(array,-2,6)));
//Console.WriteLine(FindNumber(1,array));
