string[] people = Console.ReadLine().Split(" ");
string[] xyz = Console.ReadLine().Split(" ");
int x =  int.Parse(xyz[0]);

int result = 0;
for  (int i = 0; i < 4; i++)
{
    if (int.Parse(people[i]) == x)
    {
        result = i + 1;
        break;
    }
}

Console.WriteLine(result);
