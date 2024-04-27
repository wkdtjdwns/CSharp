# 문자열 연결

- 문자열과 문자열 사이에 연산자 `+` 를 사용해 문자열을 결합함. → **연결**

```csharp
string first_name = "김";
string last_name = "성일";

string name = first_name + last_name;

Console.WriteLine(name); // 김성일 출력
```

---

- `**string.Concat()**` 사용

```csharp
string first_name = "김";
string last_name = "성일";

string name = string.Concat(first_name, last_name);

Console.WriteLine(name); // 김성일 출력
```

---

- **숫자와 문자열 연결**

```csharp
int x = 10;
int y = 20;
int z = x + y; // 30

string x = "10";
string y = "20";
string z = x + y; // 1023
```
