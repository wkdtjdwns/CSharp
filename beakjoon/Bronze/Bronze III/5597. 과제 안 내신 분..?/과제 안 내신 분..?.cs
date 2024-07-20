int[] students = new int[30];
for (int i = 1; i <= 30; i++) { students[i - 1] = i; }

Array.Sort(students);
for (int i = 0; i < 28; i++) { students[int.Parse(Console.ReadLine()) - 1] = 0; }

foreach (int stu in students)
{
    if (stu != 0)
    {
        Console.WriteLine(stu);
    }
}
