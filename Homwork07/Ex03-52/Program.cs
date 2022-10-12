// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Программа работает, на имеем выход за пределы массива....вообще не понимаю куда копать...подскажите плиз

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
        
        result[i] =  (array[i, j]  + array[i+1,j] + array[i+2,j])/3.00 ;//ВОТ ТУТ ПРОБЛЕМА! ВЫХОД ЗА ПРЕДЕЛЫ МАССИВА.ПОДСКАЖИТЕ
        
        Console.Write(result[i].ToString("F" + 2) + "  ");

    }
}