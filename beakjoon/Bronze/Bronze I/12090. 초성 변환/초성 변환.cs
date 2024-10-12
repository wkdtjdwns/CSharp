string str = Console.ReadLine();
string result = "";

char[] choSeong = new char[]
{
    'ㄱ', 'ㄲ', 'ㄴ', 'ㄷ', 'ㄸ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅃ',
    'ㅅ','ㅆ', 'ㅇ', 'ㅈ', 'ㅉ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ'
};

foreach (char c in str)
{
    if (c >= 0xAC00 && c <= 0xD7A3)
    {
        int index = c - 0xAC00;
        result += choSeong[index / 588];
    }
}

Console.WriteLine(result);
