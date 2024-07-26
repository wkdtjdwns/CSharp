string result = "";

int[] seconds = { 300, 60, 10 };
int t = int.Parse(Console.ReadLine());

if (t % 10 != 0) { Console.WriteLine("-1"); }
else
{
    foreach (int s in seconds)
    {
        result += (t / s + " ");
        t %= s;
    }

    Console.WriteLine(result);
}
