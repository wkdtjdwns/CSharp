int[] chess = { 1, 1, 2, 2, 2, 8 };
string[] input = Console.ReadLine().Split();

for (int i =  0; i < input.Length; i++)
{
    int result = chess[i] - int.Parse(input[i]);
    Console.Write(result + " ");
}
