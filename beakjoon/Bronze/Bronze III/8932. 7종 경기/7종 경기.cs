int n = int.Parse(Console.ReadLine());
int[] arr = new int[7];
for (int i = 0; i < n; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    int sum = 0;
    for (int j = 0; j < 7; j++)
    {
        arr[j] = int.Parse(a[j]);
    }

    sum += (int)(9.23076 * Math.Pow((26.7 - arr[0]), 1.835));
    sum += (int)(1.84523 * Math.Pow((arr[1] - 75), 1.348));
    sum += (int)(56.0211 * Math.Pow((arr[2] - 1.5), 1.05));
    sum += (int)(4.99087 * Math.Pow((42.5 - arr[3]), 1.81));
    sum += (int)(0.188807 * Math.Pow((arr[4] - 210), 1.41));
    sum += (int)(15.9803 * Math.Pow((arr[5] - 3.8), 1.04));
    sum += (int)(0.11193 * Math.Pow((254 - arr[6]), 1.88));

    Console.WriteLine((int)sum);
}
