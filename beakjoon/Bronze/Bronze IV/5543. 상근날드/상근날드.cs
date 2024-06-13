int sang = int.Parse(Console.ReadLine());
int jung = int.Parse(Console.ReadLine());
int ha = int.Parse(Console.ReadLine());

int cola = int.Parse(Console.ReadLine());
int cider = int.Parse(Console.ReadLine());

int burger = Math.Min(Math.Min(sang, jung), ha);
int drink = Math.Min(cola, cider);

Console.WriteLine(burger + drink - 50);
