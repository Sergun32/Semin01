Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());
 int max = 0;
if(b > a)
{
    max = b;
   
}
else
{
    max = a;
    
}
Console.Write("Максимальное значение: " + max);