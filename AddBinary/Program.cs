string AddBinary(string a, string b)
{
    var aLength = a.Length - 1;
    var bLength = b.Length - 1;
    var carry = 0; 

    var chars = new List<char>();

    while (aLength >= 0 || bLength >= 0 || carry > 0)
    {
        var sum = carry;
        
        if (aLength >= 0) sum += a[aLength--] - '0';
        if (bLength >= 0) sum += b[bLength--] - '0';
        
        chars.Add((char)('0' + (sum % 2)));
        carry = sum / 2;
    }

    chars.Reverse();
    return new string(chars.ToArray());
}

Console.WriteLine(AddBinary("1111", "1111"));