int n = int.Parse(Console.ReadLine());
n %= 8;

Console.WriteLine((n > 5 || n == 0 ? (10 - n) % 8 : n));
