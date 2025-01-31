﻿int RomanToInt(string s)
{
    var map = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    var sum = 0;
    var maxIndice = 'I';

    for (var x = s.Length - 1; x >= 0; x--)
    {
        if (map[maxIndice] > map[s[x]])
            sum -= map[s[x]];
        else
        {
            sum += map[s[x]];
            maxIndice = s[x];
        }
    }

    return sum;
}

var input = "MCMXCIV";

Console.WriteLine(RomanToInt(input));