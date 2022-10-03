int[] array = new int[10];
int length = array.Length;
int res = 0;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 30);

    Console.Write(array[i] + " ");


}
for (int i = 1; i < length; i = i + 2)
    res += array[i];
Console.WriteLine();
Console.WriteLine("Сумма элементов под нечетными индексами :  " + res);


