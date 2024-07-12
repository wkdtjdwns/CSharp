string[] abc = Console.ReadLine().Split(" ");
int a = int.Parse(abc[0]);
int b = int.Parse(abc[1]);
int c = int.Parse(abc[2]);

if (a + b == c) { Console.WriteLine($"{a}+{b}={c}"); }
else if (a - b == c) { Console.WriteLine($"{a}-{b}={c}"); }
else if (a * b == c) { Console.WriteLine($"{a}*{b}={c}"); }
else if (a / b == c) { Console.WriteLine($"{a}/{b}={c}"); }
else if (a == b + c) { Console.WriteLine($"{a}={b}+{c}"); }
else if (a == b - c) { Console.WriteLine($"{a}={b}-{c}"); }
else if (a == b * c) { Console.WriteLine($"{a}={b}*{c}"); }
else if (a == b / c) { Console.WriteLine($"{a}={b}/{c}"); }
