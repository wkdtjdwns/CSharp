string[] nkp = Console.ReadLine().Split(" ");
int n = int.Parse(nkp[0]);
int k = int.Parse(nkp[1]);
int p = int.Parse(nkp[2]);

int[] breads = new int[n * k];
string[] bread = Console.ReadLine().Split(" ");
for (int i = 0; i < n * k; i++)
{
    breads[i] = int.Parse(bread[i]);
}

int result = 0;
for (int i = 0; i < n; i++)
{
    int noCream = 0;
    for (int j = i * k; j < (i + 1) * k; j++)
    {
        if (breads[j] == 0)
        {
            noCream++;
        }
    }

    if (noCream < p)
    {
        result++;
    }
}

Console.WriteLine(result);
