int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

int sum = 0;
if (a < 0)
{
	sum = (Math.Abs(a) * c) + d + (b * e); 
}

else if (a == 0)
{
	sum = d + (b * e);
}

else
{
	sum = (b - a) * e;
}

Console.WriteLine(sum);
