int n = int.Parse(Console.ReadLine());
string[] a = Console.ReadLine().Split(" ");

int odd = 0;
int even = 0;
for (int i = 0; i < n; i++)
{
    if (int.Parse(a[i]) % 2 == 0)
    {
        even++;
    }

    else
    {
        odd++;
    }
}

if (odd == even || (odd - even) == 1)
{
    Console.WriteLine(1);
}

else
{
    Console.WriteLine(0);
}
