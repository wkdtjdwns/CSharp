string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);
int[] people = new int[n];
for (int i = 0; i < n; i++)
{
    people[i] = i + 1;
}

int cur = 0;
int index = 0;
int[] result = new int[n];
Console.Write("<");
for (int i = 0; i < n; i++)
{
    cur = (cur + k - 1) % (n - i);
    result[index++] = people[cur];

    for (int j = cur; j < n - i - 1; j++)
    {
        people[j] = people[j + 1];
    }
}

for (int i = 0; i < n - 1; i++)
{
    Console.Write($"{result[i]}, ");
}

Console.WriteLine($"{result[n - 1]}>");
