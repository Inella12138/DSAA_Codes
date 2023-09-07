using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ImplementListsWithLinkedLists
{
    internal class LList
    {
        private int numElements;

        public Node? Head { set; get; }

        public LList() 
        {
            Head = null;
            numElements = 0;
        }

        public Node? GetNodeAt(int index)
        {
            Node? link = null;
            if (index >= 0 && index <= numElements - 1)
            {
                if (index == 0 && numElements > 0)
                {
                    return Head;
                }
                else
                {
                    link = Head;
                    for (int i = 0; i < index; i++)
                    {
                        link = link.Next;
                    }
                    return link;
                }
            }
            return link;
        }

        public void Add(string newElement)
        {
            Node newNode = new Node(newElement);
            if (numElements == 0) 
            {
                Head = newNode;
            }
            else
            {
                Node? lastNode = GetNodeAt(numElements - 1);
                lastNode.Next = newNode;
            }
            numElements++;
        }

        public void Insert(int index, string newElement)
        {
            if (index >= 0 && index <= numElements)
            {
                Node newNode = new Node(newElement);
                if (index == 0)
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
                else
                {
                    Node? nodeBefore = GetNodeAt(index - 1);
                    Node? nodeAfter = nodeBefore.Next;
                    nodeBefore.Next = newNode;
                    newNode.Next = nodeAfter;
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
                    Node? nodeBefore = GetNodeAt(index - 1);
                    Node? nodeToRemove = nodeBefore.Next;
                    Node? nodeAfter = nodeToRemove.Next;
                    nodeBefore.Next = nodeAfter;
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
