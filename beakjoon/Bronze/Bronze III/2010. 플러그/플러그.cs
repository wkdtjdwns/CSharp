int sum = 0;
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
}

Console.WriteLine(sum - (n - 1));
