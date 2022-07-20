int[,,] CreateMatrix(int m, int n, int b)
{
    int[,,] matrix = new int[m, n, b];
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[j, k, i] = num;
                num++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("{0}({1},{2},{3})\t", matrix[j, k, i], j, k, i);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int b = Convert.ToInt32(Console.ReadLine());

PrintMatrix(CreateMatrix(m, n, b));
