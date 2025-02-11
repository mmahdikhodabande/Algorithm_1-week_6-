
static int FindLongestIncreasingSubarray(int[] arr)
{
    if (arr == null || arr.Length == 0)
        return 0;

    int maxLength = 1;
    int currentLength = 1;


    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[i - 1])
        {

            currentLength++;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }
        else
        {

            currentLength = 1;
        }
    }

    return maxLength;
}




int[] arr1 = new int[] { 1, 2, 3, 2, 5, 6, 7 };
Console.WriteLine($"Length of the longest consecutive ascending subsequence : {FindLongestIncreasingSubarray(arr1)}"); // خروجی: 3

int[] arr2 = new int[] { 5, 4, 3, 2, 1 };
Console.WriteLine($"Length of the longest consecutive ascending subsequence : {FindLongestIncreasingSubarray(arr2)}"); // خروجی: 1

int[] arr3 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine($"Length of the longest consecutive ascending subsequence : {FindLongestIncreasingSubarray(arr3)}"); // خروجی: 5
