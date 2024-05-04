// string : 변경할 수 없는 형식, 변경을 계속하면 string을 계속 생성함.
// StringBuilder : 변경 가능한 문자열 Class

// StringBuilder의 메소드
// Append()
// AppendLine()
// Insert()
// Replace()
// Length
// ToString()

using System.Text;

int N = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

for (int i = 1; i <= N; i++) sb.AppendLine(i.ToString());
Console.WriteLine(sb);
