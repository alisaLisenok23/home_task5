/*задача 1. задать массив заполненный случайными положительными трехзначными числами. 
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
int find_min_max(int[] arr)
{ 
    int diff=0,min=0,max=0;
    for(int i=0;i<arr.Length;i++)
        {
            if(arr[min]>arr[i])
                min=i;
                else if(arr[max]<arr[i])
                    max=i;
        }
    if(arr[min]>arr[max])
        diff=arr[min]-arr[max];
    else if(arr[max]>arr[min])
    diff=arr[max]-arr[min];
    return diff;
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
Console.WriteLine("задать массив вещественных чисел. найти разницу между максимальным и минимальным элементами массива");
int[] array3=new int[10];
int result=0;
for(int i=0;i<array3.Length;i++)
    array3[i]=val.Next();
PrintArray(array3);
result= find_min_max(array3);
Console.WriteLine("разница межу минимальным и максимальным значениями массива = "+result);