string[] input = Console.ReadLine().Split(" ");
int t = int.Parse(input[0]);
int s = int.Parse(input[1]);

if (t >= 12 && t <= 16 && s == 0)
{
    Console.WriteLine(320);
}

else
{
    Console.WriteLine(280);
}
