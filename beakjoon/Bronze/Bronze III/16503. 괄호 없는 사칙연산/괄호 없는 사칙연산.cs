int calc(int a, char op, int b)
{
    if (op == '+') return a + b;
    else if (op == '-') return a - b;
    else if (op == '*') return a * b;
    else return a / b;
}

string[] k1op1k2op2k3 = Console.ReadLine().Split(" ");
int k1 = int.Parse(k1op1k2op2k3[0]);
char op1 = char.Parse(k1op1k2op2k3[1]);
int k2 = int.Parse(k1op1k2op2k3[2]);
char op2 = char.Parse(k1op1k2op2k3[3]);
int k3 = int.Parse(k1op1k2op2k3[4]);

int result1 = calc(calc(k1, op1, k2), op2, k3);
int result2 = calc(k1, op1, calc(k2, op2, k3));

Console.WriteLine(Math.Min(result1, result2));
Console.WriteLine(Math.Max(result1, result2));
