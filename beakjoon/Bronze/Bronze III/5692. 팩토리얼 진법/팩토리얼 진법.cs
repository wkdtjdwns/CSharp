using System.Text;

int Factorial(int n)
{
    if (n <= 1) { return 1; }
    return n * Factorial(n - 1);
}

StringBuilder sb = new StringBuilder();
while (true)
{
    string num = Console.ReadLine();
    if (num.Equals("0")) { break; }

    int index = num.Length;
    int result = 0;
    foreach (char c in num)
    {
        result += (c - '0') * Factorial(index--);
    }

    sb.Append(result + "\n");
}

Console.Write(sb);
