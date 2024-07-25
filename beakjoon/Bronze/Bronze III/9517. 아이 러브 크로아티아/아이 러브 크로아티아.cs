int k = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int time = 0;
for (int i = 0; i < n; i++)
{
    string[] tstr = Console.ReadLine().Split(" ");
    int t = int.Parse(tstr[0]);
    string str = tstr[1];
    time += t;

    if (time > 210) { break; }
    if (str.Equals("T")) { k++; }
    if (k == 9) { k = 1; }
}

Console.WriteLine(k);
