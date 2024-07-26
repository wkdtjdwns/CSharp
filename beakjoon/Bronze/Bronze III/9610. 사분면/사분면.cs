int n = int.Parse(Console.ReadLine());
int Q1 = 0, Q2 = 0, Q3 = 0, Q4 = 0, AXIS = 0;

for (int i = 0; i < n; i++)
{
    string[] xy = Console.ReadLine().Split(" ");
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);

    if (x == 0 || y == 0) { AXIS++; }

    else if (x > 0)
    {
        if (y > 0) { Q1++; }
        else { Q4++; }
    }

    else if (x < 0)
    {
        if (y > 0) { Q2++; }
        else { Q3++; }
    }
}

Console.WriteLine("Q1: " + Q1);
Console.WriteLine("Q2: " + Q2);
Console.WriteLine("Q3: " + Q3);
Console.WriteLine("Q4: " + Q4);
Console.WriteLine("AXIS: " + AXIS);
