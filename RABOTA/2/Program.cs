Console.WriteLine("\nВведите число элементов массива:  ");
int countElements = int.Parse(Console.ReadLine());
int[] myArray = new int[countElements];
for (int i = 0; i < myArray.Length; i++)
{
Console.Write("Введите элент массива:");
myArray[i] = int.Parse(Console.ReadLine());
//int min = 0;
}
int min = myArray[0];
for(int i = 0; i< myArray.Length; i++)
{
    if(min>myArray[i])
{
 min = myArray[i];
} 
}
Console.WriteLine(min);

//Вывод на печать
// for(int i = 0; i<myArray.Length; i++)
// {
//     Console.Write(myArray[i] + "  ");
// }