Console.Write("Введите количество вводимых чисел: ");
int kolvo = Convert.ToInt32(Console.ReadLine());

string [] array = new string [kolvo];

for( int i = 0; i< kolvo; i++)
{
    Console.Write("Введите число № {0}:  ", i+1);
    array[i] = Console.ReadLine();
}
Console.WriteLine("Введенные числа:  ");
for(int i =0; i<kolvo;i++)
{
    Console.Write(" " + array[i]);
}
int [] arrayInt = new int [kolvo];
for(int i = 0; i< kolvo;i++)
{
    arrayInt[i]= int.Parse(array[i]);
}

int result = 0;
for(int i = 0; i< kolvo-1; i++)
{
    if(arrayInt[i] >  0)result++;
}
Console.WriteLine();
Console.Write("Чисел больше нуля: " + result);