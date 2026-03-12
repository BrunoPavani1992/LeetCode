/*
 * Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
 */

int[] PlusOne(int[] digits)
{
    for (var x = digits.Length - 1; x >= 0; x--)
    {
        if (digits[x] != 9)
        {
            digits[x] += 1;
            return digits;
        } 
        else
        {
            digits[x] = 0;
        }
    }
    
    //Sacrificing memory, to prevent array shifting...
    var result = new int[digits.Length + 1];
    result[0] = 1;
    return result;
}

var digits = new[] { 9, 9 };

var result = PlusOne(digits);

foreach (var digit in result)
{
    Console.WriteLine(digit.ToString() + ' ');
}