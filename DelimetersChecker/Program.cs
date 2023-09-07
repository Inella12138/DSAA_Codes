string input1 = "a {b [c(d + e)/2 - f] +1}";
string input2 = "a {b [c (d + e)/2 - f  ] + 1";
string input3 = "{a [b + (c + 2)/d ] + e) + f }";
Console.WriteLine(CheckDelimeter(input1));
Console.WriteLine(CheckDelimeter(input2));
Console.WriteLine(CheckDelimeter(input3));

static bool IsOpenDelimeter(char ch)
{
    return ch == '(' || ch == '[' || ch == '{';
}

static bool IsCloseDelimeter(char ch)
{
    return (ch == ')' || ch == ']' || ch == '}');
}

static bool IsPaired(char open, char close)
{
    return (open == '(' && close == ')') ||
           (open == '[' && close == ']') ||
           (open == '{' && close == '}');
}

bool CheckDelimeter(string input)
{
    Stack<char> open = new();
    Queue<char> close = new();
    for (int i = 0; i < input.Length; i++)
    {
        if (IsOpenDelimeter(input[i]))
        { 
            open.Push(input[i]);
        }
        if (IsCloseDelimeter(input[i]))
        {
            close.Enqueue(input[i]);
        }
    }
    if (open.Count != close.Count)
    {
        return false;
    }
    else
    {
        if (!IsPaired(open.Pop(), close.Dequeue()))
        {
            return false;
        }
    }
    return true;
}