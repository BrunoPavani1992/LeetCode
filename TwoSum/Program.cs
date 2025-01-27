int[] TwoSum(int[] nums, int target)
{
    var map = new Dictionary<int, int>();

    for (var i = 0; i < nums.Length; i++)
    {
        if (map.ContainsKey(target - nums[i]))
            return [map[target - nums[i]], i];
        else
            map.TryAdd(nums[i], i);
    }

    return [];
}

var nums = new[] { 2, 7, 11, 15 };
const int tgt = 9;

var result = TwoSum(nums, tgt);
Console.WriteLine(string.Join(",", result));