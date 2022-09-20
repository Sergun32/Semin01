Console.Clear();
Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение c: ");
int c = Convert.ToInt32(Console.ReadLine());


int max = a;
while (max < b)
{
 max = b;
}
while (max < c)
{
    max = c;
}
Console.WriteLine("Максимальное значение: " + max);