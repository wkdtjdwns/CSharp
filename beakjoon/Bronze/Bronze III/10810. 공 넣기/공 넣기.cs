string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int[] basket = new int[n];
for (int o = 0; o < m; o++)
{
    string[] ijk = Console.ReadLine().Split(" ");
    int i = int.Parse(ijk[0]);
    int j = int.Parse(ijk[1]);
    int k = int.Parse(ijk[2]);

    for (int p = i - 1; p < j; p++)
    {
        basket[p] = k;
    }
}

foreach (int result in basket)
{
    Console.Write(result + " ");
}
