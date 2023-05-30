// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 999);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] arr = GetArray(10, 100, 999); 

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2 == 0)
    count++;
}
 Console.Write("=> "+count);
