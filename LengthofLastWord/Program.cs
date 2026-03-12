int LengthOfLastWord(string s) {
    s = s.Trim();

    for (var x = s.Length - 1; x >= 0; x--)
        if (s[x].ToString() == " ") return s[^(s.Length - 1 - x)..].Length;

    return s.Length;
}

Console.Write(LengthOfLastWord("a"));