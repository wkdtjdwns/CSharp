string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);

string[] gi = Console.ReadLine().Split(" ");
for (int i = 0; i < k; i++)
{
    int g = int.Parse(gi[i]);
    int p = (g * 100) / n;

    if (p <= 4) Console.Write("1 ");
    else if (p <= 11) Console.Write("2 ");
    else if (p <= 23) Console.Write("3 ");
    else if (p <= 40) Console.Write("4 ");
    else if (p <= 60) Console.Write("5 ");
    else if (p <= 77) Console.Write("6 ");
    else if (p <= 89) Console.Write("7 ");
    else if (p <= 96) Console.Write("8 ");
    else Console.Write("9 ");
}
