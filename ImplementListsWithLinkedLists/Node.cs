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
            //每个节点由两部分组成：Data和Next
            Data = data;
            //Data是string类型，存储数据
            Next = null;
            //Next是Node类型，存储另一个节点(嵌套)
        }
        //链表如何达到存储一串数据的目的？链表的每个节点分为两部分，存储数据和指向下一个节点
        //定义一个节点的同时，在定义的节点里有下一个节点的内容，也就是嵌套
        
        public string Data { set; get; }

        public Node? Next { set; get; }
        //Node?允许Next为空值(null)
    }
}
