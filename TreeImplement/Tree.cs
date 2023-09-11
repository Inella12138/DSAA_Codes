using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplement
{
    public class Tree
    {
        private int numElements;

        public TreeNode? Root { get; set; }

        public Tree()
        {
            Root = null;
            numElements = 0;
        }

        //typically, inserting an element into a tree need to follow some basic rules
        //here I'll implement a binary search tree

        public void Insert(int newElement)
        {
            TreeNode newNode = new TreeNode(newElement);
            
            if (Root == null)//最简单的情况，树里没有元素，则新元素成为根
            {
                Root = newNode;
            }
            else
            {
                RInsert(newNode, Root);//一般插入情况下，调用递归方法
                numElements++;
            }
        }

        //注：也可以把Insert(),RInsert()方法写成一个函数，像课件中的一样，但是这样操作的缺点是会导致
        //Insert()方法不仅需要插入数值的输入，还需要手动输入根节点，个人认为不够简洁
        //这里让Insert()调用RInsert()，在主程序调用时更简洁，且能避免Root为null时可能引发的输入为空的问题(吗?)
        //递归查找插入位置
        private void RInsert(TreeNode newNode, TreeNode branch)
        {
            if (newNode.Val > branch.Val)
            {
                if(branch.Right == null)
                {
                    branch.Right = newNode;
                }
                else
                {
                    RInsert(newNode, branch.Right);
                    //新元素大于节点元素，且节点右分支不为空时，递归地比较新元素和右分支节点元素
                }
            }
            else
            {
                if(branch.Left == null)
                {
                    branch.Left = newNode;
                }
                else
                {
                    RInsert(newNode, branch.Left);
                }
            }
        }

        //同上，这里也用Find()调用RFind()的操作
        public bool Find(int target)
        {
            if (Root == null) 
            {
                return false;
            }
            return RFind(target, Root);
        }

        private bool RFind(int target, TreeNode branch)
        {
            if (branch == null)
            {
                return false;
            }
            if (target == branch.Val)
            {
                return true;
            }
            else if (target < branch.Val)
            {
                return RFind(target, branch.Left);
            }
            else
            {
                return RFind(target, branch.Right);
            }
        }

        public void Remove(int delnum)
        {
            TreeNode? nodeToDel = FindNode(delnum, Root);//找到要删除的节点
            TreeNode? nodeToDelParent = FindParentNode(delnum, Root);//找到要删除节点的父节点

            if (nodeToDel.Left == null && nodeToDel.Right == null)//要删除的节点没有子节点 
            {
                if (nodeToDelParent != null)//观察是否是根节点
                {
                    if(nodeToDelParent.Left == nodeToDel)//观察删除的节点是上级节点的哪个子节点
                    {
                        nodeToDelParent.Left = null;
                    }
                    else
                    {
                        nodeToDelParent.Right = null;
                    }
                }
                else    //是根节点
                {
                    Root = null;
                }
            }

            else if (nodeToDel.Right == null)//删除节点只有左节点
            {
                if (nodeToDelParent != null)//观察是否是根节点 
                {
                    if (nodeToDelParent.Left == nodeToDel)
                    {
                        nodeToDelParent.Left = nodeToDel.Left;
                    }
                    else nodeToDelParent.Right = nodeToDel.Left;
                }
                else    //是根节点
                {
                    Root = nodeToDel.Left;
                }
            }

            else if (nodeToDel.Left == null)//删除节点只有右节点
            {
                if (nodeToDelParent != null)//观察是否是根节点 
                {
                    if (nodeToDelParent.Left == nodeToDel)
                    {
                        nodeToDelParent.Left = nodeToDel.Right;
                    }
                    else nodeToDelParent.Right = nodeToDel.Right;
                }
                else    //是根节点
                {
                    Root = nodeToDel.Right;
                }
            }

            else    //删除的节点有两个子节点，选择节点右节点下最小的点替换删除节点
            {
                TreeNode? minNode = FindMinNode(nodeToDel.Right);
                TreeNode? minNodeParent = FindParentNode(minNode.Val, nodeToDel.Right);

                if (nodeToDelParent != null)//是否根节点
                {
                    if (nodeToDelParent.Left == nodeToDel)
                    {
                        nodeToDelParent.Left = minNode;
                    }
                    else
                    {
                        nodeToDelParent.Right = minNode;
                    }
                }
                else    //根节点情况
                {
                    Root = minNode;
                }

                minNode.Left = nodeToDel.Left;

                // 检查 minNode 是否是 nodeToDel.Right 的子节点
                if (minNode != nodeToDel.Right)
                {
                    minNode.Right = nodeToDel.Right;
                    minNodeParent.Left = null;
                }
                else
                {
                    minNode.Right = null;
                }
            }
        }


        /*else
        {
            TreeNode temp = nodeToDel;
            TreeNode min = temp;
            while (temp != null)
            {
                min = temp;
                temp = temp.Left;
            }
            TreeNode minParent = FindParentNode(min.Val,nodeToDel);
            if (nodeToDelParent.Left == nodeToDel)
            {
                nodeToDelParent.Left = min;
            }
            else    
            {
                nodeToDelParent.Right = min;
            }
            min.Left = nodeToDel.Left;
            min.Right = nodeToDel.Right;
            if(minParent.Left == min)
            {
                minParent.Left = null;
            }
            else minParent.Right = null;
        }*/

        private TreeNode? FindMinNode(TreeNode? node)
        {
            while (node != null && node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        private TreeNode FindNode(int target, TreeNode branch)
        {
            if (target == branch.Val)
            {
                return branch;
            }
            else if (target < branch.Val)
            {
                if (branch.Left != null)
                {
                    return FindNode(target, branch.Left);
                }
            }
            else
            {
                return FindNode(target, branch.Right);
            }
        }

        private TreeNode FindParentNode(int target, TreeNode branch)
        {
            if (branch == null) 
            { 
            }
            if (target == branch.Left.Val || target == branch.Right.Val)
            {
                return branch;
            }
            else if (target < branch.Val)
            {
                return FindParentNode(target, branch.Left);
            }
            else
            {
                return FindParentNode(target, branch.Right);
            }
        }

        public void Print(Tree tree)
        {
            if (tree.Root == null)
            {
                return;
            }
            PrintNodesPre(tree.Root);
            Console.WriteLine();
            PrintNodesIno(tree.Root);
            Console.WriteLine();
            PrintNodesPost(tree.Root);
            Console.WriteLine();
        }

        private void PrintNodesPre(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.Val + "\t");
            PrintNodesPre(node.Left);
            PrintNodesPre(node.Right);
        }

        private void PrintNodesIno(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            PrintNodesIno(node.Left);
            Console.Write(node.Val + "\t");
            PrintNodesIno(node.Right);
        }

        private void PrintNodesPost(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            PrintNodesPost(node.Left);
            PrintNodesPost(node.Right);
            Console.Write(node.Val + "\t");
        }
    }
}
