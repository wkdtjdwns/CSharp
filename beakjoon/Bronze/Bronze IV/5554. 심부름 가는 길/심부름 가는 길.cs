int homeSchool = int.Parse(Console.ReadLine());
int schoolPc = int.Parse(Console.ReadLine());
int pcAcademy = int.Parse(Console.ReadLine());
int academyHome = int.Parse(Console.ReadLine());

int time = homeSchool + schoolPc + pcAcademy + academyHome;
int minute = time / 60;
int second = time % 60;

Console.WriteLine(minute);
Console.WriteLine(second);
