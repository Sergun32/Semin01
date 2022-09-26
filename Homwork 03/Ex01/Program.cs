Console.Write("Введите проверяемое значение: ");
string text = Console.ReadLine();


bool Palindrom(string text)
{
for(int i = 0; i < text.Length/2; ++i)
if(text[i] != text[text.Length - 1 -i]) return false;
return  true;
}
bool proverks = Palindrom(text);
Console.WriteLine(proverks);