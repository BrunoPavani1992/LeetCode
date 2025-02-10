int RemoveDuplicates(int[] nums)
{
    var list = new List<int>();

    foreach (var n in nums)
    {
        if (list.Any(x => x == n))
            continue;

        list.Add(n);
    }
    
    Array.Clear(nums);

    for (var i = 0; i < list.Count; i++)
    {
        nums[i] = list[i];
    }

    return list.Count;
}

var input = new int[] { 1, 1, 2 };
var k = RemoveDuplicates(input);
Console.WriteLine(k);