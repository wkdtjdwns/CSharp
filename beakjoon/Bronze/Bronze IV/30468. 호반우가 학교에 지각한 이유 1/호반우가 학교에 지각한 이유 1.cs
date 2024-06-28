string[] sdiln = Console.ReadLine().Split(" ");
int Str = int.Parse(sdiln[0]);
int Dex = int.Parse(sdiln[1]);
int Int = int.Parse(sdiln[2]);
int Luk = int.Parse(sdiln[3]);
int n = int.Parse(sdiln[4]);

int totalStatus = Str + Dex + Int + Luk;

if (totalStatus < (4 * n))
{
    Console.WriteLine((4 * n) - totalStatus);
}

else
{
    Console.WriteLine(0);
}
