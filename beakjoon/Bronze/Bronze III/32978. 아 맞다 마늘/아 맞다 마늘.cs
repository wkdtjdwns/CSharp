int n = int.Parse(Console.ReadLine());
string[] recipe = Console.ReadLine().Split(" ");
string[] hyunBin = Console.ReadLine().Split(" ");

for (int i = 0; i < n; i++)
{
    if (!hyunBin.Contains(recipe[i]))
    {
        Console.WriteLine(recipe[i]);
        break;
    }
}
