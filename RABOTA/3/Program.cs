void FillArray(int[] coll)
{
    int lends = coll.Length;
    int i = 0;
    while (i < lends)
    {
        coll[i] = new Random().Next(1, 10);
        i++;
    }
}
void PrintArray(int[] collektor)
{
    int count = collektor.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(collektor[pos]);
        pos++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
