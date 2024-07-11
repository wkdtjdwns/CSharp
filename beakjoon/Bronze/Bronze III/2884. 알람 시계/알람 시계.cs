string[] hm = Console.ReadLine().Split(" ");
int h = int.Parse(hm[0]);
int m = int.Parse(hm[1]);

m -= 45;
if (m < 0)
{
    m += 60;
    h = --h < 0 ? h-- + 24 : h--;
}

Console.WriteLine(h + " " + m);
