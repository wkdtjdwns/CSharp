using System.Text;

StringBuilder sb = new StringBuilder();

List<int> nums = new List<int>();
string line;
while ((line = Console.ReadLine()) != null)
{
    sb.Append(line);
}

string[] s = sb.ToString().Split(",");
int result = 0;
for (int i = 0; i < s.Length; i++)
{
    result += int.Parse(s[i]);
}

Console.WriteLine(result);
