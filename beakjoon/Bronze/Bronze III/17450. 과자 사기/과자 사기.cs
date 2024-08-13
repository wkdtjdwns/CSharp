double max = 0;
string snack = "";

for (int i = 1; i <= 3; i++)
{
    string[] pw = Console.ReadLine().Split(" ");
    double price = double.Parse(pw[0]);
    double weight = double.Parse(pw[1]);
    double money = 0;

    if (price * 10 >= 5000)
    {
        money = (weight * 10) / (price * 10 - 500);
    }

    else
    {
        money = (weight * 10) / (price * 10);
    }

    if (max < money)
    {
        max = money;
        if (i == 1)
        {
            snack = "S";
        }

        else if (i == 2)
        {
            snack = "N";
        }

        else
        {
            snack = "U";
        }
    }
}

Console.WriteLine(snack);
