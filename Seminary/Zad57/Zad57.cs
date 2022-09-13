// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();

CountNumbersInArray(array);

///////////////////////////////////////////////////////////////////////////
// Задает массив случайными числами
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// Выводит заданный массив на экран
void PrintArray(int[,] inArray)
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
// Определяет и выводит на экран количество повторяющихся элементов(частотный словарь)
void CountNumbersInArray(int[,] arr)
{
    int[,] arrcopy =new int[arr.GetLength(0), arr.GetLength(1)];
    Array.Copy(arr, arrcopy, arr.Length);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int count = 0;
            for (int ic = 0; ic < arrcopy.GetLength(0); ic++)
            {
                for (int jc = 0; jc < arrcopy.GetLength(1); jc++)
                {
                    if(arr[i,j] == arrcopy[ic,jc])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{arr[i,j]} встречается {count} раза ");
        }
    }
}
