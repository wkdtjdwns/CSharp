string[] xyr1 = Console.ReadLine().Split(" ");
int x1 = int.Parse(xyr1[0]);
int y1 = int.Parse(xyr1[1]);
int r1 = int.Parse(xyr1[2]);

string[] xyr2 = Console.ReadLine().Split(" ");
int x2 = int.Parse(xyr2[0]);
int y2 = int.Parse(xyr2[1]);
int r2 = int.Parse(xyr2[2]);
if (1l * (x1 - x2) * (x1 - x2)  + 1l * (y1 - y2) * (y1 - y2) < 1l * (r1 + r2) * (r1 + r2))
{
    Console.WriteLine("YES");
}

else
{
    Console.WriteLine("NO");
}
