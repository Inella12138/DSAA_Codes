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
            return (impl == "recursive") ? RReverse(str) : IReverse(str);
        }


        public static string RReverse(string str)
        {
            if (str == "") { return ""; }
            return str.Substring(str.Length - 1, 1) + RReverse(str.Substring(0, str.Length - 1));
        }

        public static string IReverse(string str)
        {
            string rstr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rstr += str[i];
            }
            return rstr;
        }
    } 
}
