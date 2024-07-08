for (int i = 0; i < 2; i++)
{
    string[] tfspc = Console.ReadLine().Split(" ");
    int t = int.Parse(tfspc[0]);
    int f = int.Parse(tfspc[1]);
    int s = int.Parse(tfspc[2]);
    int p = int.Parse(tfspc[3]);
    int c = int.Parse(tfspc[4]);

    Console.Write((t * 6) + (f * 3) + (s * 2) + p + (c * 2) + " ");
}
