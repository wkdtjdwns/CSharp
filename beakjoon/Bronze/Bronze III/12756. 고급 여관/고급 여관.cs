string[] a = Console.ReadLine().Split(" ");
int aAttack = int.Parse(a[0]);
int aHp = int.Parse(a[1]);

string[] b = Console.ReadLine().Split(" ");
int bAttack = int.Parse(b[0]);
int bHp = int.Parse(b[1]);

while (true)
{
    aHp -= bAttack;
    bHp -= aAttack;

    if (bHp <= 0 && aHp >= 1)
    {
        Console.WriteLine("PLAYER A");
        break;
    }

    else if (aHp <= 0 && bHp >= 1)
    {
        Console.WriteLine("PLAYER B");
        break;
    }

    else if (aHp >= 1 && bHp >= 1)
    {
        continue;
    }

    else
    {
        Console.WriteLine("DRAW");
        break;
    }

}
