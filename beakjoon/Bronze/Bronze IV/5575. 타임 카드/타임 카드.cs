for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine().Split(" ");

    int h1 = int.Parse(input[0]);
    int m1 = int.Parse(input[1]);
    int s1 = int.Parse(input[2]);

    int h2 = int.Parse(input[3]);
    int m2 = int.Parse(input[4]);
    int s2 = int.Parse(input[5]);

    int t1 = h1 * 3600 + m1 * 60 + s1;
    int t2 = h2 * 3600 + m2 * 60 + s2;
    int t = t2 - t1;

    int h = t / 3600 % 24;
    int m = t / 60 % 60;
    int s = t % 60;

    Console.WriteLine(h + " " + m + " " + s);
}
