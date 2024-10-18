List<long> arr = new List<long>();
Dictionary<long, int> map = new Dictionary<long, int>();
int n = int.Parse(Console.ReadLine());
int temp = 0;

for (long i = 1; i <= 1000000000000000000L; i *= 2)
{
    arr.Add(i);
    map[i] = temp++;
}

for (int i = 0; i < n; i++)
{
    long find = long.Parse(Console.ReadLine());
    for (int j = 0; j < arr.Count; j++)
    {
        long complement = find - arr[j];
        if (map.TryGetValue(complement, out int index2))
        {
            int index1 = j;
            Console.WriteLine($"{Math.Min(index1, index2)} {Math.Max(index1, index2)}");
            break;
        }
    }
}
