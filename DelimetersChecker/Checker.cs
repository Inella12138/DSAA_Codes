using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelimetersChecker
{
    public class Checker
    {
        public static bool IsOpenDelimeter(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{';
        }

        public static bool IsCloseDelimeter(char ch)
        {
            return ch == ')' || ch == ']' || ch == '}';
        }

        public static bool IsDelimeter(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{' || ch == ')' || ch == ']' || ch == '}';
        }

        public static bool IsPaired(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }

        public static bool CheckDelimeter(string input)
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

        //或许可以用递归的方法完成上述操作
        public static bool RecursionChecker(string input)
        {
            string dms = "";
            for (int i = 0; i< input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                {
                    dms += input[i];
                }
            }
            if ((dms.Length % 2) != 0)
            {
                return false;
            }
            else return IsDelimeterPaierd(dms);
        }

        public static bool IsDelimeterPaierd(string input)
        {
            if (input == "")
            {
                return true;
            }
            if (!IsPaired(input[0], input[input.Length - 1]))
            {
                return false;
            }
            else
            {
                string output = input.Substring(1, input.Length - 2);
                return IsDelimeterPaierd(output);
            }
        }
    }
}
