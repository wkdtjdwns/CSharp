# 수학 함수들
- `Math.Max(x, y)` : x와 y에서 가장 **높은 값**을 반환함.

```csharp
int max_value = Math.Max(5, 10);
Console.WriteLine("5, 10 - Max : " + max_value);

// 5, 10 - Max : 10
```

---

- `Math.Min(x, y)` : x와 y에서 가장 **낮은 값**을 반환

```csharp
int min_value = Math.Min(5, 10);
Console.WriteLine("5, 10 - Min : " + min_value);

// 5, 10 Min : 5
```

---

- `Math.Sqrt(x)` : x의 **제곱근**을 반환함.

```csharp
int sqrt_value= Math.Sqrt(64);
Console.WriteLine("64 - Sqrt : " + sqrt_value);

// 64 - Sqrt : 8
```

---

- `Math.Abs(x)` : x의 **절댓값**을 반환함.

```csharp
double abs_value = Math.Abs(-4.7);
Console.WriteLine("-4.7 - Abs : " + abs_value);

// -4.7 - Abs : 4.7
```

---

- `Math.Ceiling(x)` : x를 **올림**한 값을 반환

```csharp
double ceiling_value = Math.Ceiling(3.3);
Console.WriteLine("3.3 - Ceiling : " + ceiling_value);

// 3.3 - Ceiling : 4
```

---

- `Math.Round(x)` : x를 **반올림**한 정수를 반환

```csharp
double round_value = Math.Round(9.99);
Console.WriteLine("9.99 - Round : " + round_value);

// 9.99 - Round : 10
```

---

- `Math.Truncate(x)` : x를 **내림**한 정수를 반환

```csharp
double truncate_value = Math.Truncate(3.9);
Console.WriteLine("3.9 - Truncate : " + truncate_value);

// 3.9 - Truncate : 3
```
