string mbti = Console.ReadLine();
foreach (char c in mbti)
{
    switch (c)
    {
        case 'E': Console.Write("I"); break;
        case 'S': Console.Write("N"); break;
        case 'F': Console.Write("T"); break;
        case 'P': Console.Write("J"); break;
        case 'I': Console.Write("E"); break;
        case 'N': Console.Write("S"); break;
        case 'T': Console.Write("F"); break;
        case 'J': Console.Write("P"); break;
    }
}
