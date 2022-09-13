// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите нижнюю границу диапазона: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите верхнюю границу диапазона: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();

OrderRowsArray(array);
PrintOrdenRowsArray(array);

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
// Упорядочивает числа в строках заданного массива
void OrderRowsArray(int[,]amessarray)
{
    for (int i = 0; i < amessarray.GetLength(0); i++)
    {
        for (int j = 0; j < amessarray.GetLength(1); j++)
        {
            for (int x = 0; x < amessarray.GetLength(1)-1; x++)// дополнительная переменная для перключения столбцов
            {
                if(amessarray[i,x] < amessarray[i,x+1])
                {
                    int vrem = amessarray[i,x]; // временное хранилище
                    amessarray[i,x] = amessarray[i,x+1];
                    amessarray[i,x+1] = vrem;
                }
            }
        }
    }
}
// Выводит  массив c упорядоченными строками на экран
void PrintOrdenRowsArray(int[,]orderrowsarray)
{
    for (int i = 0; i < orderrowsarray.GetLength(0); i++)
    {
        for (int j = 0; j < orderrowsarray.GetLength(1); j++)
        {
            Console.Write($"{orderrowsarray[i, j]} ");
        }
        Console.WriteLine();
    }
}
