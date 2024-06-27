int total = 0;

for (int i = 0; i < 8; i++)
{
    string chess = Console.ReadLine();
    foreach (char c in chess)
    {
        switch (c)
        {
            case 'P': total += 1; break;
            case 'N': total += 3; break;
            case 'B': total += 3; break;
            case 'R': total += 5; break;
            case 'Q': total += 9; break;
            case 'p': total -= 1; break;
            case 'n': total -= 3; break;
            case 'b': total -= 3; break;
            case 'r': total -= 5; break;
            case 'q': total -= 9; break;
        }
    }
}

Console.WriteLine(total);
