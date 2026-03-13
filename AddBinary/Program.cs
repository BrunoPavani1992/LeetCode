string AddBinary(string a, string b)
{
    var result = "";
    var plusOne = false;

    while (a.Length > b.Length)
        b = "0" + b;

    while (a.Length < b.Length)
        a = "0" + a;

    while (a != "" || b != "")
    {
        if (a[^1].ToString() == "0" && b[^1].ToString() == "0")
        {
            if (!plusOne) result = "0" + result;
            else
            {
                result = "1" + result;
                plusOne = false;
            }
        }
        else if ((a[^1].ToString() == "1" && b[^1].ToString() == "0") ||
                 (a[^1].ToString() == "0" && b[^1].ToString() == "1"))
        {
            if (!plusOne) result = "1" + result;
            else result = "0" + result;
        }
        else
        {
            if (!plusOne) result = "0" + result;
            else result = "1" + result;
            plusOne = true;
        }

        a = a.Remove(a.Length - 1, 1);
        b = b.Remove(b.Length - 1, 1);
    }

    if (plusOne) result = "1" + result;

    return result;
}

Console.WriteLine(AddBinary("1111", "1111"));