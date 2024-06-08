string[] input = Console.ReadLine().Split(" ");
int a = int.Parse(input[1]);
int b = int.Parse(input[2]);

Console.WriteLine((a < b) ? "Bus" : (a > b) ? "Subway" : "Anything");
