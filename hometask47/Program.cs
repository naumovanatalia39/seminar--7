// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// метод для создания двумерного массива
double[,] GetRandomMatrix(int rows, int columns)
{
    Random x = new Random();
    double[,] matr = new double[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(x.Next(-100, 100) / 10.0);
        }
    }
    return matr;
}

// метод для печати (вывода в консоль) двумерного массива
void PrintMatrix(double[,] matr)
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

int rowsCount = ReadInt("Введите число строк");
int columsCount = ReadInt("Введите число столбцов");
double[,] matrix = GetRandomMatrix(rowsCount, columsCount);

PrintMatrix(matrix);