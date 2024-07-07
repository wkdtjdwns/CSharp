int sum = 0;
int minValue = 100;

for (int i = 0; i < 7; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 1)
    {
        sum += n;

        if (n < minValue)
        {
            minValue = n;
        }
    }
}

if (sum == 0)
{
    Console.WriteLine(-1);
}

else
{
    Console.WriteLine(sum);
    Console.WriteLine(minValue);
}
