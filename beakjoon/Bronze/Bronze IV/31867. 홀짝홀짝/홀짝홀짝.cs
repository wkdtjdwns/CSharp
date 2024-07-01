int n = int.Parse(Console.ReadLine());
char[] k = Console.ReadLine().ToCharArray();

int even = 0;
int odd = 0;
for (int i = 0; i < n; i++)
{
    if ((k[i] - '0') % 2 == 0)
    {
        even++;
    }

    else
    {
        odd++;
    }
}

if (even > odd)
{
    Console.WriteLine(0);
}

else if (even < odd)
{
    Console.WriteLine(1);
}

else
{
    Console.WriteLine(-1);
}
