int[,] GetMatrix (int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1) - 1) Console.Write($"{array[i,j], 3},");
            else Console.Write($"{array[i,j], 3}]");
        }
        Console.WriteLine();
    }    
}

int[] GetIndMin (int[,] matrix)
{
    int min = matrix[0,0];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i,j]) 
            {    
                min = matrix[i,j];
                m = i;
                n = j;
            }
        }
    }
    return new int[] {m,n};
}

int[,] GetNewMatrix (int[,]matrixResult, int[] array)
{
    int[,] matrix = new int[matrixResult.GetLength(0)-1, matrixResult.GetLength(1)-1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (m == array[0]) m++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (n == array[1]) n ++;
           matrix[i,j] = matrixResult[m,n];
           n++;
        }
        n = 0;
        m++;
    }
    return matrix;
}
int[,] matrixResult = GetMatrix(3,4);
PrintMatrix(matrixResult);
Console.WriteLine();

int[ ] fingMinCross = GetIndMin(matrixResult);

int[,] matrix = GetNewMatrix(matrixResult, fingMinCross);
PrintMatrix(matrix);