
static bool IsBalanced(string str)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in str)
    {
        if (c == '(' || c == '{' || c == '[' || c == '`')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']' || c == '`')
        {
            if (stack.Count == 0)
                return false;

            char top = stack.Pop();

            if ((c == ')' && top != '(') ||
                (c == '}' && top != '{') ||
                (c == ']' && top != '[') ||
                (c == '`' && top != '`'))
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}
Console.WriteLine(IsBalanced("[]}"));