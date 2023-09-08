using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_CountString
{
    public static class CountStrLen
    {
        public static int Count(string str, string impl = "recursive")
        {
            if (impl != "recursive" && impl != "iterative")
            {
                throw new Exception("Unknown implement type.");
            }
            return (impl == "recursive") ? RCount(str) : ICount(str);
        }

        private static int RCount(string str)
        {
            if (str == "")
            {
                return 0;
            }
            return 1 + RCount(str.Remove(0, 1));
        }

        private static int ICount(string str)
        {
            int cnt = 0;
            while (str != "")
            {
                cnt++;
                str = str.Remove(0, 1);
            }
            return cnt;
        }
    }
}
