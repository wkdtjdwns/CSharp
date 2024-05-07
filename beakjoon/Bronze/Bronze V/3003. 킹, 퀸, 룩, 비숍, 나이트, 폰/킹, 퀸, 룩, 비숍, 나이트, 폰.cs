int[] chess = { 1, 1, 2, 2, 2, 8 };
string[] input = Console.ReadLine().Split();
int[] result = new int[6];

for (int i =  0; i < input.Length; i++)
{
    result[i] = chess[i] - int.Parse(input[i]);
}

foreach (int num in result)
{
    Console.Write(num + " ");
}
