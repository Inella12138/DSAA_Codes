using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplement
{
    public class TreeNode
    {
        public TreeNode(int val)
        {
            Val = val;
            Left = null;
            Right = null;
        }

        public int Val { get; set; }

        public TreeNode? Left { get; set; }

        public TreeNode? Right { get; set; }
    }
}
