void Merge(int[] nums1, int m, int[] nums2, int n)
{
    var i = m - 1;     
    var j = n - 1;
    var k = m + n - 1;

    while (j >= 0)
    {
        if (i >= 0 && nums1[i] > nums2[j])
        {
            nums1[k--] = nums1[i--];
        }
        else
        {
            nums1[k--] = nums2[j--];
        }
    }
    
    Console.WriteLine(string.Join(" ", nums1));
}


var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var m = 3;
var nums2 = new int[] {2, 5, 6};
var n = 3;


/*
var nums1 = new int[] { 1 };
var m = 1;
var nums2 = new int[] { };
var n = 0;
*/

Merge(nums1, m, nums2, n);