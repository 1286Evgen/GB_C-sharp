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
if (columnsA != rowsB)
{
    Console.WriteLine("Матрицы А и В не могут быть перемножены");
    return;    
}

int[,] resultMatrix = new int[rowsA,columnsB]; // создал пустую матрицу

MultiplyMatrix(matrixA, matrixB, resultMatrix); // находим произведение двух матриц и записываем результат в пустую матрицу
PrintArray(resultMatrix);

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
void MultiplyMatrix(int[,] firstMat, int[,] secomdMat, int[,] resultMat)
{
  for (int i = 0; i < resultMat.GetLength(0); i++)
  {
    for (int j = 0; j < resultMat.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMat.GetLength(1); k++)
      {
        sum += firstMat[i,k] * secomdMat[k,j];
      }
      resultMat[i,j] = sum;
    }
  }
}
