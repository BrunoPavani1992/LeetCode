int RemoveDuplicates(int[] nums)
{
    var nextIndex = 0;
    var unique = nums[nextIndex];
    var i = 1;
    while (i < nums.Length)
    {
        if (nums[i] != unique)
        {
            nextIndex++;
            unique = nums[i];
            nums[nextIndex] = unique;
        }

        i++;
    }

    return nextIndex + 1;
}

var input = new int[] { 1, 1, 2 };
var k = RemoveDuplicates(input);
Console.WriteLine(k);