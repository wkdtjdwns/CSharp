string[] ckp = Console.ReadLine().Split(" ");
int c = int.Parse(ckp[0]);
int k = int.Parse(ckp[1]);
int p = int.Parse(ckp[2]);

int result = 0;
for (int i = 1; i <= c; i++)
{
    result += (k * i + p * i * i);
}

Console.WriteLine(result);
