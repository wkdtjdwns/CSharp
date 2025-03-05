string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int[] basket = new int[n];
for (int i = 0; i < n; i++)
{
    basket[i] = i + 1;
}

for (int k = 0; k < m; k++)
{
    string[] ij = Console.ReadLine().Split(" ");
    int i = int.Parse(ij[0]) - 1;
    int j = int.Parse(ij[1]) - 1;
    

    while (i < j)
    {
        int temp = basket[i];

        basket[i++] = basket[j];
        basket[j--] = temp;
    }
}

foreach (int b in basket)
{
    Console.Write(b + " ");
}
