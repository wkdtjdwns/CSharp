string v = Console.ReadLine();
string ab = Console.ReadLine();
int a = 0;
int b = 0;
foreach (char c in ab)
{
    if (c == 'A') { a++; }
    else { b++; }
}

Console.WriteLine(a > b ? "A" : a < b ? "B" : "Tie");
