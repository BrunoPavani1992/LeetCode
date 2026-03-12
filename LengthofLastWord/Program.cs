int LengthOfLastWord(string s) {
    s = s.Trim();

    var word = "";
    var reset = false;

    foreach (var c in s)
    {
        if (c.ToString() == " ")
        {
            reset = true;
        }
        else
        {
            if (reset)
            {
                reset = false;
                word = "";
            }
            word += c;    
        }
    }

    return word.Length;
}

Console.Write(LengthOfLastWord("   fly me   to   the moon  "));