using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_ReverseString
{
    public static class ReverseString
    {
        public static string Reverse(string str, string impl = "recursive")
        {
            if (impl != "recursive" && impl != "iterative")
            {
                throw new Exception("Unknown implement type.");
            }
            if (str.Length == 0)
            {
                return "";
            }
            Stack<char> chars = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                chars.Push(str[i]);
            }
            return (impl == "recursive") ? RReverse(chars) : IReverse(chars);
        }


        private static string RReverse(Stack<char> stack)
        {
            if (stack.Count == 0) { return ""; }
            return stack.Pop() + RReverse(stack);
        }

        private static string IReverse(Stack<char> stack)
        {
            string rstr = "";
            while (stack.Count() > 0) 
            {
                rstr += stack.Pop();
            }
            return rstr;
        }
    } 
}
