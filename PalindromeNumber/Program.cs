bool IsPalindrome(int x)
{
    if (x < 0)
        return false;
    
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

const int input = -1000;

Console.WriteLine($"{input} is palindrome? " + IsPalindrome(input));