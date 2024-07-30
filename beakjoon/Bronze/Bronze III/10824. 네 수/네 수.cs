string[] abcd = Console.ReadLine().Split(" ");
string ab = abcd[0] + abcd[1];
string cd = abcd[2] + abcd[3];

Console.WriteLine(long.Parse(ab) + long.Parse(cd));
