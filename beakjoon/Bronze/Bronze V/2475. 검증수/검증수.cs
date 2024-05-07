string[] input = Console.ReadLine().Split();

int sum = 0;
for (int i = 0; i < input.Length; i++)
{
    sum += (int)Math.Pow(int.Parse(input[i]), 2);
}

int result = sum % 10;
Console.WriteLine(result);
