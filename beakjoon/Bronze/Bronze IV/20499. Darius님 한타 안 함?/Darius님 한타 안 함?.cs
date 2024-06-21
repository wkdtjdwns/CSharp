string[] kda = Console.ReadLine().Split("/");
int k = int.Parse(kda[0]);
int d = int.Parse(kda[1]);
int a = int.Parse(kda[2]);

if (k + a < d || d == 0)
{
    Console.WriteLine("hasu");
}

else
{
    Console.WriteLine("gosu");
}
