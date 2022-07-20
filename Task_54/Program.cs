int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = new Random().Next(100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write(matrix[i, k] + "\t");
        }
        Console.WriteLine();
    }
}

void SortLineMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int temp;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,j] > matrix[i,k])
                {
                    temp = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(m, n);

PrintMatrix(matrix);
SortLineMatrix(matrix);
PrintMatrix(matrix);
