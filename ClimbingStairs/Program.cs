int ClimbStairs(int n)
{
    if (n <= 3) return n;

    var x = n - 3;
    var i = 3;
    var j = 2;
    
    while (x > 0)
    {
        var aux = i;
        i += j;
        j = aux;
        
        x--;
    }

    return i;
}

Console.WriteLine(ClimbStairs(5));
Console.WriteLine(ClimbStairs(6));

/* FIB...
1 1 1
1 2
2 1

3

1 1 1 1
1 1 2
1 2 1
2 1 1
2 2

5

1 1 1 1 1 
1 1 1 2
1 1 2 1
1 2 1 1
2 1 1 1
1 2 2
2 1 2
2 2 1

8

1 1 1 1 1 1
1 1 1 1 2
1 1 1 2 1
1 1 2 1 1
1 2 1 1 1
2 1 1 1 1
1 1 2 2
1 2 1 2
2 1 1 2
1 2 2 1
2 1 2 1
2 2 1 1
2 2 2

13

1 1 1 1 1 1 1
1 1 1 1 1 2
1 1 1 1 2 1
1 1 1 2 1 1
1 1 2 1 1 1 
1 2 1 1 1 1
2 1 1 1 1 1
1 1 1 2 2
1 1 2 1 2
1 2 1 1 2
2 1 1 1 2
1 1 2 2 1
1 2 1 2 1
2 1 1 2 1
1 2 2 1 1
2 1 2 1 1
2 2 1 1 1
1 2 2 2
2 1 2 2
2 2 1 2
2 2 2 1

21
*/