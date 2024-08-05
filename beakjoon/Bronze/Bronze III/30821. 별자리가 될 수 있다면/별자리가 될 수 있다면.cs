int n = int.Parse(Console.ReadLine());
long cnt = 1;
for (int i = 0; i < 5; i++)
{
    cnt *= (n - i);
}

for (int i = 0; i < 5; i++)
{
    cnt /= (i + 1);
}

Console.WriteLine(cnt);
