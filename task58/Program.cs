// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] matrixA, int[,] matrixB, int[,] matrixAB)
{
    for (int i = 0; i < matrixAB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixAB.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                temp += matrixA[i, k] * matrixB[k, j];
            }
            matrixAB[i, j] = temp;
            System.Console.Write($"{matrixAB[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Дан двумерный массив A ");
int[,] matrixA = new int[2, 2];
FillMatrixWhithRandomNumbers(matrixA);
PrintMatrix(matrixA);

System.Console.WriteLine("Дан двумерный массив B ");
int[,] matrixB = new int[2, 2];
FillMatrixWhithRandomNumbers(matrixB);
PrintMatrix(matrixB);
System.Console.WriteLine("Произведение матриц");
int[,] matrixAB = new int[2, 2];
MatrixMultiplication(matrixA, matrixB, matrixAB);