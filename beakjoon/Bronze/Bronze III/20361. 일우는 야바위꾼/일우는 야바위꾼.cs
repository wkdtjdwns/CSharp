string[] nxk = Console.ReadLine().Split(" ");
int x = int.Parse(nxk[1]);
int k = int.Parse(nxk[2]);
for (int i = 0; i < k; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    
    if (a == x)
    {
        x = b;
    }

    else if (b == x)
    {
        x = a;
    }
}

Console.WriteLine(x);
