- `[ ]` (대괄호) 안의 int 값을 넣어서 문자에 접근할 수 있음.

```csharp
string str= "안녕 세상아!";
Console.WriteLine(str[0]);  // 안 출력
```

---

- `IndexOf()` : 해당 문자열의 인덱스를 반환함.

```csharp
string str= "안녕 세상아!";
Console.WriteLine(str.IndexOf("세")); // 3 출력 (컴퓨터는 0부터 시작함)
```

---

- `Substring()` : 해당 인덱스의 문자부터 출력함.

```csharp
string str= "안녕 세상아!";

// 3번째 문자부터 출력 -> 세상아! 출력
Console.WriteLine(str.Substring(3));
```

---

- **모든 함수 응용**

```csharp
// 문자열
string str = "안녕 세상아!";

// "세"의 인덱스를 가져와서 저장함
int char_pos = str .IndexOf("세"); // char_pos = 3

// 문자를 "세"부터 시작하도록 함
string write_str = str.Substring(char_pos);

// 결과 출력 -> 세상아! 출력
Console.WriteLine(write_str);
```
