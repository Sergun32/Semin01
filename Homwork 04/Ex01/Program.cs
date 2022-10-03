int [] array =new int [10];
int lends = array.Length;
int i = 0;
while( i < lends)
{
    array[i] = new Random().Next(100, 1000);
    i++;
}
int count = 0;

for(i = 0; i < lends; i++)
//int count = 0;

{
    Console.WriteLine(array[i]);
    if(array[i]%2==0)
    {
       count++; 
    }
    
}

Console.WriteLine(count);