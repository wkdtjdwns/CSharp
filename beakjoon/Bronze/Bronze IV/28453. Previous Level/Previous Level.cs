int n = int.Parse(Console.ReadLine());
string[] m = Console.ReadLine().Split(" ");
foreach (string str in m)
{
    int level = int.Parse(str);
    if (level >= 300) { Console.Write(1 + " "); }
    else if (level >= 275) { Console.Write(2 + " "); }
    else if (level >= 250) { Console.Write(3 + " "); }
    else { Console.Write(4 + " "); }
}
