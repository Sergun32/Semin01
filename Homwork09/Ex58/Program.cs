// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine($"\nЗадайте размеры матриц:");
int m = InputNumbers("Задайте число строк 1-й матрицы: ");
int n = InputNumbers("Задайте число столбцов 1-й матрицы: ");
int t = InputNumbers("Задайте число столбцов 2-й матрицы: ");
int[,] firstMatr = new int[m, n];
CreateArray(firstMatr);
Console.WriteLine($"\nВот первая матрица:");
WriteArray(firstMatr);

int[,] secondMatr = new int[n, t];
CreateArray(secondMatr);
Console.WriteLine($"\nА вот вторая матрица:");
WriteArray(secondMatr);

int[,] resMatr = new int[m,t];

MultiplyMatrix(firstMatr, secondMatr, resMatr);
Console.WriteLine($"\nВот так результат произведения матриц:");
WriteArray(resMatr);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}