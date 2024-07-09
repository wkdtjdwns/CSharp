int[] changes = { 25, 10, 5, 1 };
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int c = int.Parse(Console.ReadLine());
    int[] result = new int[4];

    for (int j = 0; j < changes.Length; j++)
    {
        result[j] = c / changes[j];
        c %= changes[j];
    }

    foreach (int res in result)
    {
        Console.Write(res + " ");
    }
}
