// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        
    }
}


int[,] matrix = GetRandomMatrix(4, 5);
PrintMatrix(matrix);
Console.WriteLine();
double arithmeticMean = 0.00;
for (int i = 0; i < matrix.GetLength(1); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            arithmeticMean = arithmeticMean + matrix[j, i];
        }
        Console.Write($"{arithmeticMean / matrix.GetLength(0)}, ");
        arithmeticMean = 0.00;
    }
