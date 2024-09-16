string[] nx = Console.ReadLine().Split(" ");
int n = int.Parse(nx[0]);
int x = int.Parse(nx[1]);

int[] array = new int[n];
string[] a = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(a[i]);
}

int index = 0;
while (true)
{
    if (array[index] < x)
    {
        Console.WriteLine(index % n + 1);
        return;
    }

    index++;
    index %= n;
    x++;
}
