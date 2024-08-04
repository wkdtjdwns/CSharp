int[] results = new int[31];
for (int i = 0; i < 31; i++)
{
    results[i] = (int)Math.Pow(2, i);
}

int n = int.Parse(Console.ReadLine());
if (results.Contains(n))
{
    Console.WriteLine(1);
}

else
{
    Console.WriteLine(0);
}
