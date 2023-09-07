using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementListsWithLinkedLists
{
    internal class Node
    {
        //Constructor
        public Node(string data) 
        {
            Data = data;
            Next = null;
        }   
        public string Data { set; get; }

        public Node? Next { set; get; }
        //Node?允许Next为空值(null)
    }
}
