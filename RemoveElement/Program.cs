int RemoveElement(int[] nums, int val)
{
    var valCount = 0;
    var i = 0;

    while (i < nums.Length)
    {
        if (nums[i] == val)
            valCount++;
        else
        {
            if (valCount > 0)
                nums[i-valCount] = nums[i];
        }

        i++;
    }

    return nums.Length - valCount;
}

var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
var val = 2;

var k = RemoveElement(nums, val);
Console.WriteLine(k);