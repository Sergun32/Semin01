int [] array = {4,24,3,47,56,67,77,8,829,31};
int length = array.Length;
Console.WriteLine("Исходный массив");
for (int i = 0; i < length; i++)
{

    Console.Write(array[i] + " ");
}

 int min = array[0];
 int max = array[0];

for (int i = 0; i < length; i++)
{
    if (array[i] < array[min])
    {
        min = i;
    }
    else if (array[i] > array[max])
    {
        max = i;
    }
}
Console.WriteLine("\nМинимальный элемент: " + array[min]);

Console.WriteLine("Максимальный элемент: " + array[max]);

Console.WriteLine("\nЭлементы между минимум и максимом");
for (int i = min + 1; i < max; i++) Console.Write(array[i] + " ");

