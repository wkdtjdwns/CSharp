string[] abcd = Console.ReadLine().Split(" ");
Array.Sort(abcd);

Console.WriteLine(int.Parse(abcd[0]) * int.Parse(abcd[2]));
