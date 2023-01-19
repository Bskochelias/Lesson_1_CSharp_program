int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int c = new Random().Next(1,100);
int d = new Random().Next(1,100);
int e = new Random().Next(1,100);
Console.Write("A = ");
Console.WriteLine(a);
Console.Write("B = ");
Console.WriteLine(b);
Console.Write("C = ");
Console.WriteLine(c);
Console.Write("D = ");
Console.WriteLine(d);
Console.Write("E = ");
Console.WriteLine(e);

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальное число равно: ");
Console.WriteLine(max);
