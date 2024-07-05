int result = 0;
int now = 0;

for (int i = 0; i < 4; i++)
{
    string[] outin = Console.ReadLine().Split(" ");

    now -= int.Parse(outin[0]);
    now += int.Parse(outin[1]);
    result = Math.Max(result, now);
}

Console.WriteLine(result);
