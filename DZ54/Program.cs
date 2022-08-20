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

void GetSortMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if(matrix[i,k] < matrix[i,k + 1]) 
                {
                    int temp = matrix[i,k + 1];
                    matrix[i,k + 1] = matrix[i,k+1];
                    matrix[i,k + 1] = temp;
                }
            }
        }
         
    }
}

int[,] matrixResult = GetMatrix(3,4);
PrintMatrix(matrixResult);
Console.WriteLine();

GetSortMatrix(matrixResult);
PrintMatrix(matrixResult);

