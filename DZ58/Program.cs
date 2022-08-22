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

int[,] matrixResult1 = GetMatrix(4,4);
PrintMatrix(matrixResult1);
Console.WriteLine();
int[,] matrixResult2 = GetMatrix(4,5);
PrintMatrix(matrixResult2);
Console.WriteLine();

int[,] GetMatrixComposition(int[,] matrix1, int[,] matrix2, int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix2.GetLength(1); ++j)
        {  
            for (int k = 0; k < matrix1.GetLength(0); ++k)
            {
                matrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }      
        }  
    }
    return matrix;        
}      

int[,] composition = GetMatrixComposition(matrixResult1, matrixResult2, 4, 5);
PrintMatrix(composition);