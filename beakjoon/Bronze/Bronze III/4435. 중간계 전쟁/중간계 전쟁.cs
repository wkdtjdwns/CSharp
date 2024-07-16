int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    string[] b = Console.ReadLine().Split(" ");
    int scoreA = int.Parse(a[0]) + int.Parse(a[1]) * 2 + int.Parse(a[2]) * 3
                    + int.Parse(a[3]) * 3 + int.Parse(a[4]) * 4 + int.Parse(a[5]) * 10;
    
    int scoreB = int.Parse(b[0]) + int.Parse(b[1]) * 2 + int.Parse(b[2]) * 2
                    + int.Parse(b[3]) * 2 + int.Parse(b[4]) * 3 + int.Parse(b[5]) * 5
                    + int.Parse(b[6]) * 10;

    Console.Write("Battle " + i + ": ");
    if (scoreA > scoreB) { Console.WriteLine("Good triumphs over Evil"); }
    else if (scoreA < scoreB) { Console.WriteLine("Evil eradicates all trace of Good"); }
    else { Console.WriteLine("No victor on this battle field"); }
}
