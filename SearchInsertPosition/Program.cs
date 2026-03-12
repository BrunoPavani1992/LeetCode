int SearchInsert(int[] nums, int target) {
    var midIndex =  nums.Length / 2;

    if (target == nums[midIndex]) return midIndex;

    if (target < nums[midIndex])
    {
        for (var x = midIndex; x >= 0; x--)
        {
            if (nums[x] == target) return x;
            if (nums[x] < target) return x+1;
        }

        return 0;
    }
    
    if (target > nums[midIndex])
    {
        for (var x = midIndex; x <= nums.Length - 1; x++)
        {
            if (nums[x] == target) return x;
            if (nums[x] > target) return x;
        }

        return nums.Length;
    }

    return 0;
}

var nums = new[] {1, 3, 5, 6};
Console.WriteLine(SearchInsert(nums, 5));
Console.WriteLine(SearchInsert(nums, 2));
Console.WriteLine(SearchInsert(nums, 7));

var nums2 = new[] {1,3,5};
Console.WriteLine(SearchInsert(nums2, 4));