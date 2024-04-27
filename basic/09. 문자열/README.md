# 문자열

- **문자열**은 **텍스트를 저장**하는 자료형임.
- **문자열**은 **“ “ (큰따옴표)로 묶어서 표현**함.

```csharp
string str = "Hello";
string str2 = "Nice to meet you!";
```

---

### 문자열 길이 확인

---

- `.Length` : 문자열 뒤에 붙여서 문자열의 길이를 int형으로 반환함.

```csharp
string str = "ABCDEFGHIJKLNMOPQRSTUVWXYZ";
Console.WriteLine("문자열 길이 : " + str.Length); // 26
```

### 문자열 대/소문자 변경

---

- `.ToUpper()` : 문자열을 전부 대문자로 바꿈.
- `.ToLower()` : 문자열을 전부 문자로 바꿈.

```csharp
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // HELLO WORLD 출력
Console.WriteLine(txt.ToLower());   // hello world 출력
```
