Console.WriteLine("N : ");
int n = Convert.ToInt32(Console.ReadLine());
List<int> list_Divided_by = new List<int>();

for (int i = 1; i <= n / 2; i++)
{
    if (n % i == 0)
    {
        list_Divided_by.Add(i);
    }
}
list_Divided_by.Add(n);
if (list_Divided_by.Count == 2)
{
    Console.WriteLine("Prime");
}
