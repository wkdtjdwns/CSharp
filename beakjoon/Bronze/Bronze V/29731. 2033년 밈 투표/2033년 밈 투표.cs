string[] promises =
{
    "Never gonna give you up",
    "Never gonna let you down",
    "Never gonna run around and desert you",
    "Never gonna make you cry",
    "Never gonna say goodbye",
    "Never gonna tell a lie and hurt you",
    "Never gonna stop"
};

bool check = false;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    String p = Console.ReadLine();

    if (Array.IndexOf(promises, p) == -1)
    {
        check = true;
    }
}

if (check)
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
