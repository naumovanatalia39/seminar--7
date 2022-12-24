// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 9)
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


int rowsPosition = ReadInt("Введите номер строки");
int columsPosition = ReadInt("Введите номер столбца");
int[,] matrix = GetRandomMatrix(5, 7);
PrintMatrix(matrix);
Console.WriteLine();
if(rowsPosition < matrix.GetLength(0) && columsPosition < matrix.GetLength(1))
{
    Console.WriteLine(matrix[rowsPosition,columsPosition]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}