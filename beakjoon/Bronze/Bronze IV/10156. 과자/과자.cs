string[] input = Console.ReadLine().Split(" ");
int k = int.Parse(input[0]);
int n = int.Parse(input[1]);
int m = int.Parse(input[2]);

int result = (k * n) > m ? (k * n) - m : 0;
Console.WriteLine(result);
