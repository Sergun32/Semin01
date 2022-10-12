int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

double[] result = new double [3];


for (int i = 0; i <4;i++)
{
    for (int j = 0; j <=3; j++)
    {
        
        result[i] =  (array[i, j]  + array[i+1,j] + array[i+2,j])/3.00 ;
        
        Console.Write(result[i].ToString("F" + 2) + "  ");

    }
}