Console.Write("Введите число строк массива:  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива:  ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i, j] = new Random().Next(1,25)/10.0;
    Console.Write($"{array[i, j]} ");
    }
Console.WriteLine();
}
