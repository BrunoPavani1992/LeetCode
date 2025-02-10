int StrStr(string haystack, string needle)
{
    var i = 0;
    var match = 0;
    var size = needle.Length;

    while (i < haystack.Length)
    {
        if (haystack[i] == needle[match])
        {
            match++;
            i++;
        }
        else
        {
            i = i - match + 1;
            match = 0;
        }

        if (match == size)
            return i - match;
    }

    return -1;
}

const string haystack = "mississippi";
const string needle = "issi";

Console.WriteLine(StrStr(haystack, needle));