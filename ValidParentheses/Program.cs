bool IsValid(string s)
{
    var stack = new Stack<char>();

    foreach (var chr in s)
    {
        if (ToPush(chr))
            stack.Push(chr);
        else
        {
            if (stack.Count == 0)
                return false;
            
            if (ExpectedChar(chr) != stack.Peek())
                return false;
            
            stack.Pop();
        }
    }

    return stack.Count <= 0;
}

bool ToPush(char chr)
{
    return chr switch
    {
        '(' => true,
        '[' => true,
        '{' => true,
        ')' => false,
        ']' => false,
        _ => false
    };
}

char ExpectedChar(char chr)
{
    return chr switch
    {
        ')' => '(',
        ']' => '[',
        _ => '{',
    };
}

const string s = "()[]{}";

Console.WriteLine(IsValid(s));