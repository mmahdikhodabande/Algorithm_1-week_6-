
static int MaxProductOfThree(int[] nums)
{
    if (nums.Length < 3)
        throw new ArgumentException("Array must contain at least three numbers.");

    Array.Sort(nums);

    int n = nums.Length;


    int maxProduct = Math.Max(
        nums[n - 1] * nums[n - 2] * nums[n - 3],
        nums[0] * nums[1] * nums[n - 1]
    );

    return maxProduct;
}

static void Main()
{
    int[] nums = { -10, -10, 5, 2 };
    Console.WriteLine("Max Product: " + MaxProductOfThree(nums));
}

