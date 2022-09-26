
Console.Write("Введите значение числа:  ");
int cube = Convert.ToInt32(Console.ReadLine());


void Cube(int[] cube)
{

    int length = cube.Length;

    for (int count = 0; count < length; count++)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));

    }
}
void PrintArr(int[] poz)
{
    int count1 = poz.Length;
    for(int index = 1; index < count1; index++)
    
    {
        Console.Write(poz[index] + "  ");
        
    }
}

int[] arry = new int[cube + 1];
Cube(arry);
PrintArr(arry);
