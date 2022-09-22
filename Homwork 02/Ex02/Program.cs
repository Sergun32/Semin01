int [] array = {1,2,3,4,5,6,7};
int n = array.Length;
Console.WriteLine("Здравствуйте!!!");
Console.Write("Введите цифру дня недели: ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;
while(index < n)
{

if(array[^1] == find)
{
    Console.WriteLine("ВЫХОДНОЙ");
    break;
}

if(array[^2] == find)
{
Console.WriteLine("ВЫХОДНОЙ");
    break;
}
else
{
    Console.WriteLine("РАБОЧИЙ");
    break;
}
}

