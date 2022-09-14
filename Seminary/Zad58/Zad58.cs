using System.Globalization;
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк матрицы А: ");
int rowsA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов матрицы А: ");
int columnsA = int.Parse(Console.ReadLine() ?? "");
int[,] matrixA = GetMatrix (rowsA, columnsA, 0, 9);
PrintArray(matrixA);
Console.WriteLine();
Console.Write("Введите количество строк матрицы В: ");
int rowsB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов матрицы В: ");
int columnsB = int.Parse(Console.ReadLine() ?? "");
int[,] matrixB = GetMatrix (rowsB, columnsB, 0, 9);
PrintArray(matrixB);
Console.WriteLine();

// Проверка возможности получения произведения двух матриц
if (rowsA != columnsB)
{
    Console.WriteLine("Матрицы А и В не могут быть перемножены");
} 
int[,] resmatrix = GetResultMatrix (matrixA, matrixB);
PrintArray(resmatrix);
Console.WriteLine();

///////////////////////////////////////////////////////////////////////////
// Задает матрицу и заполняет ее случайными числами
int[,] GetMatrix (int m, int n, int minValue, int maxValue)
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
// Выводит матрицу на экран
void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Находит произведение двух матрих
int[,] GetResultMatrix (int[,] matrixA, int[,] matrixB);
{
    int[,] resmat = new int[matrixB.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int res = 0;
            for (int x = 0; x < matrixA.GetLength(0); x++)
            {
                res = res + matrixA [x,j] * matrixB[i,x];
            }
            resmat[i,j] = res;
        }
    }
    return resmat; 
}
