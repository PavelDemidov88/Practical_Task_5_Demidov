// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] NewArr(int size)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(-10, 10);
        Console.WriteLine($"{"El: "}{res[i]} ");
    }
    return res;
}
int[] arr = NewArr(10);

int max = arr[0];
int min = arr[0];
for(int i=0; i<arr.Length; i++ )
{
    if(arr[i]<min)
    {
        min = arr[i];
    }
    if(arr[i]>max)
    {
        max = arr[i];
    }
}
int diff = max - min;
Console.WriteLine($"Max={max} Min = {min} Diff= {diff}");
