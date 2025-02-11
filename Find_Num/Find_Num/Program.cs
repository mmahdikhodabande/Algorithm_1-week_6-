static List<(int, int)> FindPairsWithSum(int[] arr, int target)
{
    HashSet<int> seen = new HashSet<int>();
    List<(int, int)> result = new List<(int, int)>();

    foreach (int num in arr)
    {
        int complement = target - num;
        if (seen.Contains(complement))
            result.Add((complement, num));
        seen.Add(num);
    }
    return result;
}


int[] arr = { 1, 2, 3, 4, 5 };
int target = 5;
var pairs = FindPairsWithSum(arr, target);

foreach (var pair in pairs)
{
    Console.WriteLine($"({pair.Item1}, {pair.Item2})");
}


