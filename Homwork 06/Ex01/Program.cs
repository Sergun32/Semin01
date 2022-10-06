
Console.Write(" Введите значение b1:  ");
double b1 = double.Parse(Console.ReadLine());
Console.Write(" Введите значение b2:  ");
double b2 = double.Parse(Console.ReadLine());
Console.Write(" Введите значение k1:  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write(" Введите значение k2:  ");
double k2 = double.Parse(Console.ReadLine());
double x;
double y;

// (k1 * x) + b1 == k2 * x + b2;
// (k1 * x) + k2 * x == b2 - b1;
x = (b2 - b1)/ (k1 - k2);
y = k1 * x + b1;
Console.WriteLine("Найдена точка пересечения двух прямых: ");
Console.WriteLine($"({x} ; {y})");
