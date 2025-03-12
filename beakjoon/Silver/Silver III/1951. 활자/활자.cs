long n = int.Parse(Console.ReadLine());
long cnt = 0;

while (n > 9)
{
    long length = Convert.ToString(n).Length;
    cnt += (long)((n - Math.Pow(10, length - 1) + 1) * length);
    n = (long)Math.Pow(10, length - 1) - 1;
}

cnt += n;
Console.WriteLine(cnt % 1234567);
