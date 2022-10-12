

int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 25);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
// 
Console.WriteLine("Введите значение i:  ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите знвчение j:  ");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("Искомое число;  ");

if (a > 3 || b > 3)
{
    Console.WriteLine("Нет такого значения");
}
else
{
    Console.WriteLine($"{array[a, b]} ");
}



