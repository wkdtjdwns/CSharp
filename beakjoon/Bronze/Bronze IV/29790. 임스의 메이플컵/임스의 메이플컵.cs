string[] nul = Console.ReadLine().Split(" ");
int n = int.Parse(nul[0]);
int u = int.Parse(nul[1]);
int l = int.Parse(nul[2]);

bool isBaekjoon = false;
bool isMaple = false;
if (n >= 1000) { isBaekjoon = true; }
if (u >= 8000 || l >= 260) { isMaple = true; }

if (isBaekjoon && isMaple)
{
    Console.WriteLine("Very Good");
}

else if (isBaekjoon)
{
    Console.WriteLine("Good");
}

else
{
    Console.WriteLine("Bad");
}
