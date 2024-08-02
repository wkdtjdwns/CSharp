int n = int.Parse(Console.ReadLine());
string[] mirror = new string[n];
for (int i = 0; i < n; i++)
{
    mirror[i] = Console.ReadLine();
}

int k = int.Parse(Console.ReadLine());
if (k == 1)
{
    foreach (string str in mirror)
    {
        Console.WriteLine(str);
    }
}

else if (k == 2)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = n - 1; j >= 0; j--)
        {
            Console.Write(mirror[i][j]);
        }

        Console.WriteLine();
    }
}

else
{
    for (int i = n - 1; i >= 0; i--)
    {
        Console.WriteLine(mirror[i]);
    }
}
