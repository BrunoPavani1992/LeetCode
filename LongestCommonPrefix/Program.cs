string LongestCommonPrefix(string[] strs)
{
    var prefix = strs[0];

    for (var x = 1; x < strs.Length; x++)
    {
        if (prefix.Length > strs[x].Length)
        {
            prefix = prefix[..strs[x].Length];
        }
        
        for (var y = 0; y < prefix.Length && y < strs[x].Length; y++)
        {
            if (prefix[y] == strs[x][y]) continue;
            
            prefix = prefix[..y];
            break;
        }
    }

    return prefix;
}

var strs = new string[] { "flower","flow" };

Console.WriteLine(LongestCommonPrefix(strs));