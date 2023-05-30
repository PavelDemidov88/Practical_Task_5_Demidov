// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 

int[] NewArr(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-5, 5);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] arr = NewArr(8, 1, 5);

int sum = 0;
for (int i = 1; i < arr.Length; i+=2)
{
    sum = sum + arr[i];
}

Console.Write("Сумма нечетных позиций = " +sum);
