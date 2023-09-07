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
    Stack<char> open = new();//为左括号建立一个栈
    Queue<char> close = new();//为右括号建立一个队列
    for (int i = 0; i < input.Length; i++)
    {
        if (IsOpenDelimeter(input[i]))
        { 
            open.Push(input[i]);//检测到左括号，压栈
        }
        if (IsCloseDelimeter(input[i]))
        {
            close.Enqueue(input[i]);//检测到右括号，加入队列
        }
    }
    if (open.Count != close.Count)//数量不相等则一定不匹配
    {
        return false;
    }
    else
    {
        if (!IsPaired(open.Pop(), close.Dequeue()))
            //为什么是用左括号退栈的值和右括号退出队列的值比较？
        {
            return false;
        }
    }
    return true;
}