﻿/*задача 1. задать массив заполненный случайными положительными трехзначными числами. 
написать  программу, которая покажет количество четных чисел в массиве
задача 2. задать массивзаполненный случайными числами. найти сумму элементов, стоящих не нечетных позициях
задача 3. задать массив вещественных чисел. найти разницу между максимальным и минимальным элементами массива*/
void PrintArray(int[] Array)
{
    for(int i=0;i<Array.Length;i++)
        Console.WriteLine(Array[i]);//вывод в консоль каждого элемента в новой строке
}
int Count_arr(int[]Array)
{
    int count=0;
    for(int i=0;i<Array.Length;i++)
    {
        if(Array[i]%2==0)
        count++;
    }
    return count;
}
Console.WriteLine("программа задает массив случайных трехзначных чисел");
int[] array=new int[10];//массив размером 10 элементов
Random val=new Random();
for (int i=0;i<array.Length;i++)
    array[i]=val.Next(100,999);//создание массива случайных трехзначных чисел
PrintArray(array);//вызов функции вывода на экран массива
Console.WriteLine( "в массиве "+Count_arr(array)+" четных элемента");
Console.WriteLine("задать массив заполненный случайными числами. найти сумму элементов, стоящих нa нечетных позициях");
int[] array2=new int[10];
int sum=0;
for (int i=0;i<array2.Length;i++)
    array2[i]=val.Next(0,10);
PrintArray(array2);
for (int i =0;i<array2.Length;i++)
{
    if(i%2!=0)
    sum+=array2[i];
}
Console.WriteLine("сумма нечетных элементов массива = "+sum);
