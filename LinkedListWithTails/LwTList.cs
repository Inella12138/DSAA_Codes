using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWithTails
{
    internal class LwTList
    {
        private int numElements;

        public Node? Head { set; get; }
        public Node? Tail { set; get; }

        public LwTList()
        {
            Head = null;
            Tail = null;
            numElements = 0;
        }

        public int Count()
        {
            return numElements;
        }

        public Node? GetNodeAt(int index)
        {
            Node? link = Head;
            if (index >= 0 && index <= numElements - 1)
            {
                for (int i = 0; i < index; i++)//index == n，取n次Head.Next
                {
                    link = link.Next;
                }
            }
            return link;
        }

        public void Append(string newElement)
        {
            Node newNode = new Node(newElement);//新节点
            if (numElements == 0) //如果列表里没有元素，新节点即成为Head
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;//新节点成为最后一个元素的.Next
                Tail = newNode;//新节点成为Tail
            }
            numElements++;//别忘了增加元素数量
        }

        public void Insert(int index, string newElement)
        {
            if (index >= 0 && index <= numElements)
            {
                Node newNode = new Node(newElement);//新节点
                if (index == 0)//如果是在首位插入
                {
                    newNode.Next = Head;//新节点成为Head
                    Head = newNode;//原本的首位成为新节点的.Next
                }
                else if (index == numElements - 1)
                {
                    Tail.Next = newNode;
                    Tail = newNode;
                }
                else
                {
                    Node? nodeBefore = GetNodeAt(index - 1);//在其他位置插入时，先获取插入位置之前的节点
                    Node? nodeAfter = nodeBefore.Next;//获取插入位置之后的节点
                    nodeBefore.Next = newNode;//新节点成为之前节点的.Next
                    newNode.Next = nodeAfter;//之后节点成为新节点的.Next
                }
                numElements++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= numElements - 1)
            {
                if (index == 0)
                {
                    Head = Head.Next;
                }
                else
                {
                    Node? nodeBefore = GetNodeAt(index - 1);//获得要删除节点之前的一个节点
                    Node? nodeToRemove = nodeBefore.Next;//获得要删除的节点
                    Node? nodeAfter = nodeToRemove.Next;//获得要删除节点之后的一个节点
                    nodeBefore.Next = nodeAfter;//之前节点直接连接到之后节点
                                                //(跳过删除节点达到删除节点的目的，本质上还是删除索引)
                }
                numElements--;
            }
        }

        public void Replace(int index, string newElement)
        {
            if (index >= 0 && index <= numElements - 1)
            {
                Node toReplace = GetNodeAt(index);
                toReplace.Data = newElement;
            }
        }

        public bool Contains(string element)
        {
            for (int i = 0; i < numElements; i++)
            {
                if (element.Equals(GetNodeAt(i).Data))
                {
                    return true;
                }
            }
            return false;
        }

        public void Write()
        {
            Console.WriteLine();
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine(GetNodeAt(i).Data);
            }
        }
    }
}
