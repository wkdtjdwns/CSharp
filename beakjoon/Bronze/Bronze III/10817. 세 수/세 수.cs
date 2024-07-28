string[] abc = Console.ReadLine().Split(" ");
int[] abcValue = new int[3];
abcValue[0] = int.Parse(abc[0]);
abcValue[1] = int.Parse(abc[1]);
abcValue[2] = int.Parse(abc[2]);

Array.Sort(abcValue);
Console.WriteLine(abcValue[1]);
