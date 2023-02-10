// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] MultiMatr(int[,] A, int[,] B)
{
    int rA = A.GetLength(0);
    int cA = A.GetLength(1);
    int rB = B.GetLength(0);
    int cB = B.GetLength(1);
    int temp = 0;
    int[,] result = new int[rA, cB];

    for (int i = 0; i < rA; i++)
    {
        for (int j = 0; j < cB; j++)
        {
            temp = 0;
            for (int k = 0; k < cA; k++)
            {
                temp += A[i, k] * B[k, j];
            }
            result[i, j] = temp;
        }
    }
    return result;
}


int[,] A = FillMatrix(2, 2);
System.Console.WriteLine();
PrintMatrix(A);

int[,] B = FillMatrix(2, 2);
System.Console.WriteLine();
PrintMatrix(B);
System.Console.WriteLine();

int[,] C = MultiMatr(A, B);
PrintMatrix(C);
