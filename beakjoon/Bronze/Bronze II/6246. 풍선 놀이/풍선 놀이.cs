string[] nq = Console.ReadLine().Split(" ");
int n = int.Parse(nq[0]);
int q = int.Parse(nq[1]);
bool[] slots = new bool[n];

for (int i = 0; i < q; i++)
{
    string[] li = Console.ReadLine().Split(" ");
    int l = int.Parse(li[0]);
    int interval = int.Parse(li[1]);

    for (int j = l - 1; j < n; j += interval)
    {
        if (!slots[j])
        {
            slots[j] = true;
        }
    }
}

int result = 0;
for (int i = 0; i < n; i++)
{
    if (!slots[i])
    {
        result++;
    }
}

Console.WriteLine(result);
