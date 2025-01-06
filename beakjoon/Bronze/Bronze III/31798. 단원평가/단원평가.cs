string[] abc = Console.ReadLine().Split(" ");
int a = int.Parse(abc[0]);
int b = int.Parse(abc[1]);
int c = int.Parse(abc[2]);

int result = 0;
if (a == 0)
{
    result = c * c - b;
}

else if (b == 0)
{
    result = c * c - a;
}

else
{
    result = (int)Math.Sqrt(a + b);
}


Console.WriteLine(result);
