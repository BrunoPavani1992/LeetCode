int LengthOfLastWord(string s) {
    s = s.Trim();

    var word = "";

    for (var x = s.Length - 1; x >= 0; x--)
    {
        if (s[x].ToString() == " ") return word.Length;
        word += s[x];
    }

    return word.Length;
}

Console.Write(LengthOfLastWord("   fly me   to   the moon  "));