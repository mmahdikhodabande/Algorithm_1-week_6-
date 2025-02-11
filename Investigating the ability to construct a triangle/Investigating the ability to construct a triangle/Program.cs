static bool CanFormTriangle(int[] arrayInt)
{
    if (arrayInt == null || arrayInt.Length < 3)
    {
        return false;
    }
    Array.Sort(arrayInt);
    for (int i = 0; i < arrayInt.Length - 2; i++)
    {
        if (arrayInt[i] + arrayInt[i + 1] > arrayInt[i + 2])
        {
            Console.WriteLine($"Because = [{arrayInt[i]}] +[{arrayInt[i + 1]}] > [{arrayInt[i + 2]}] ");
            return true;
        }
    }
    return false;
}
int[] arr = { 1, 2, 3};
Console.WriteLine(CanFormTriangle(arr));
