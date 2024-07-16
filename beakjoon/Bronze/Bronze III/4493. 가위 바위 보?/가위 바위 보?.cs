int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int cnt = 0;
    for (int j = 0; j < n; j++)
    {
        string[] p1p2 = Console.ReadLine().Split(" ");
        string p1 = p1p2[0];
        string p2 = p1p2[1];

        if (p1.Equals("R") && p2.Equals("S")
            || p1.Equals("S") && p2.Equals("P") || p1.Equals("P") && p2.Equals("R"))
        {
            cnt++;
        }

        else if (p1.Equals("S") && p2.Equals("R")
            || p1.Equals("P") && p2.Equals("S") || p1.Equals("R") && p2.Equals("P"))
        {
            cnt--;
        }
    }

    if (cnt > 0) { Console.WriteLine("Player 1"); }
    else if (cnt < 0) { Console.WriteLine("Player 2"); }
    else { Console.WriteLine("TIE"); }
}
