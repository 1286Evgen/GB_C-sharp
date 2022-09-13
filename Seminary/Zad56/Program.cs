// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите нижнюю границу диапазона: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите верхнюю границу диапазона: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");
int[,]array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();

//GetMinSumRow(array);

///////////////////////////////////////////////////////////////////////////
// Задает массив со случайными числами
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
// Выводит заданный массив на экран
void PrintArray(int[,]inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Определяет строку в заданном массиве с нименьшей суммой элементов

    int minsum = Int32.MaxValue;
    int indexminrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexminrow = i + 1; // фиксирует номер строки с минимальной суммой элементов
        }
    }

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexminrow) + ", с суммой елементов равной: " + (minsum));