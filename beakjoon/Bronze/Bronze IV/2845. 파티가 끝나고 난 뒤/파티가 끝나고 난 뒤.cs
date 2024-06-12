string[] lp = Console.ReadLine().Split(" ");
int l = int.Parse(lp[0]);
int p = int.Parse(lp[1]);

string[] input = Console.ReadLine().Split(" ");
for (int i = 0 ; i < 5; i++)
{
    Console.Write(int.Parse(input[i]) - (l * p) + " ");
}
