
static char FirstUniqueCharacter(string str)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();


    foreach (char c in str)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }


    foreach (char c in str)
    {
        if (charCount[c] == 1)
            return c;
    }

    return '-';
}


Console.Write("Enter a string: ");
string input = Console.ReadLine();

char result = FirstUniqueCharacter(input);

if (result == '-')
    Console.WriteLine("-1"); 
else
    Console.WriteLine($"First unique character: {result}");
