bool check = false;
for (int i = 1; i <= 5; i++)
{
    string name = Console.ReadLine();
    if (name.Contains("FBI"))
    {
        check = true;
        Console.Write(i + " ");
    }
}

if (!check)
{
    Console.WriteLine("HE GOT AWAY!");
}
