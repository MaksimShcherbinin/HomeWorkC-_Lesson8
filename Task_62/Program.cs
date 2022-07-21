void FillMatrix(ref int[,] matrix, int num, int n, int m)
{
    if (n == matrix.GetLength(0) 
        || m == matrix.GetLength(1) 
        || n < 0 
        || m < 0) return;
    if (matrix[n, m] == 0 
        && n < matrix.GetLength(0) 
        && m < matrix.GetLength(1) 
        && n >= 0 
        && m >= 0)
    {
        matrix[n, m] = num;
        num++;
        FillMatrix(ref matrix, num, n, m + 1);
        FillMatrix(ref matrix, num, n + 1, m);
        FillMatrix(ref matrix, num, n, m - 1);
        FillMatrix(ref matrix, num, n - 1, m);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
int num = 1;
FillMatrix(ref matrix, num, 0, 0);
PrintMatrix(matrix);
