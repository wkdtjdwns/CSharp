int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int[] nums = new int[10];

string abc = Convert.ToString(a * b * c);
foreach (char ch in abc)
{
    for (int i = 0; i < 10; i++)
    {
        if ((int)ch - 48 == i)
        {
            nums[i]++;
        }
    }
}

foreach (int n in nums)
{
    Console.WriteLine(n);
}
