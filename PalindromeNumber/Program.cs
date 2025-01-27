bool IsPalindrome(int x)
{
    switch (x)
    {
        case < 0:
            return false;
        case 0:
            return true;
    }

    var num = x;
    var reverseNum = 0;

    while (num > 0)
    {
        var digit = num % 10;
        reverseNum = reverseNum * 10 + digit;
        num /= 10;
    }

    return x / reverseNum == 1;
}

const int input = 121;

Console.WriteLine($"{input} is palindrome? " + IsPalindrome(input));