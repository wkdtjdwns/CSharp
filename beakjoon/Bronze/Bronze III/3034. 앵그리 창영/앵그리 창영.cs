string[] nwh = Console.ReadLine().Split(" ");
int n = int.Parse(nwh[0]);
int w = int.Parse(nwh[1]);
int h = int.Parse(nwh[2]);

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num <= w) { Console.WriteLine("DA"); }
    else if (num <= h) { Console.WriteLine("DA"); }
    else if (num <= Math.Sqrt(w * w + h * h)) { Console.WriteLine("DA"); }
    else { Console.WriteLine("NE"); }
}
