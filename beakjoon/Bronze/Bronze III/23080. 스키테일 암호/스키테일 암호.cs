int k = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
for (int i = 0; i < str.Length; i += k)
{
    Console.Write(str[i]);
}
