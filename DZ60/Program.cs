int[,,] Get3D (int x, int y, int z)
{
    int[,,] xyz = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < xyz.GetLength(0); i++)
    {
        for (int j = 0; j < xyz.GetLength(1); j++)
        {   
            for (int k = 0; k < xyz.GetLength(2); k++)
            {
                xyz[i, j, k] = rnd.Next(10, 100);
                int t = xyz[i, j, k];
                int w = 0;
                if (w == t)
                    break;
                if (w != t)
                    t = w;
            }
        }    
    }
    return xyz;
}

int[,,] xyzResult = Get3D(2, 2, 2);
Console.WriteLine($"{xyzResult[0,0,0]}(0,0,0) {xyzResult[0,1,0]}(0,1,0)");
Console.WriteLine($"{xyzResult[1,0,0]}(1,0,0) {xyzResult[1,1,0]}(1,1,0)");
Console.WriteLine($"{xyzResult[0,0,1]}(0,0,1) {xyzResult[0,1,1]}(0,1,1)");
Console.WriteLine($"{xyzResult[1,0,1]}(1,0,1) {xyzResult[1,1,1]}(1,1,1)");