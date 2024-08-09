string[] b = Console.ReadLine().Split(" ");
int bx = int.Parse(b[0]);
int by = int.Parse(b[1]);

string[] d = Console.ReadLine().Split(" ");
int dx = int.Parse(d[0]);
int dy = int.Parse(d[1]);

string[] j = Console.ReadLine().Split(" ");
int jx = int.Parse(j[0]);
int jy = int.Parse(j[1]);

int bMove = Math.Max((Math.Abs(bx - jx)), (Math.Abs(by - jy)));
int dMove = Math.Abs(dx - jx) + Math.Abs(dy - jy);

if (bMove < dMove)
{
    Console.WriteLine("bessie");
}

else if (bMove > dMove)
{
    Console.WriteLine("daisy");
}

else
{
    Console.WriteLine("tie");
}
