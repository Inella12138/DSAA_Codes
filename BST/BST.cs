using System;
using System.Collections.Generic;

namespace Algo; 

public class BST 
{
    private Node? root;

    public const int PREFIX = 1;
    public const int INFIX = 2;
    public const int POSTFIX = 3;

    public BST() 
    {
        root = null;
    }

    public bool Insert(Node node)
    {
        if (node == null) {
            // cannot insert null
            return false;
        }

        if (root == null) {
            // tree has no nodes yet, set this one as root
            root = node;
            return true;
        }

        return Insert(node, root);
    }

    private bool Insert(Node node, Node curr) 
    {
         if (node.key == curr.key) {
            return false;   // no duplicate keys allowed
        }

        if (node.key < curr.key) {                
            if (curr.left == null) {
                // found empty spot for new node
                curr.left = node;
                return true;
            }

            // go to left branch
            return Insert(node, curr.left);
        }
        else {  
            if (curr.right == null) {
                // found empty spot for new node
                curr.right = node;
                return true;
            }                

            // go to right branch
            return Insert(node, curr.right);
        }
    }

    public void DepthFirst(int mode) 
    {
        if (mode == PREFIX) {
            Prefix(root);
        }
        else if (mode == INFIX) {
            Infix(root);
        }
        else if (mode == POSTFIX) {
            Postfix(root);
        }

        // clear trailing "%" character
        Console.WriteLine("");
    }

    private void Prefix(Node? node) 
    {
        if (node == null) {
            return;
        }

        Console.Write("{0} ", node.key);
        Prefix(node.left);
        Prefix(node.right);
    }

    private void Infix(Node? node) 
    {
        if (node == null) {
            return;
        }

        Infix(node.left);
        Console.Write("{0} ", node.key);
        Infix(node.right);
    }

    private void Postfix(Node? node) 
    {
        if (node == null) {
            return;
        }

        Postfix(node.left);
        Postfix(node.right);
        Console.Write("{0} ", node.key);
    }

    public void BreadthFirst() 
    {
        List<Node> nodes = new List<Node>();

        if (root != null) {
            nodes.Add(root);
        }

        while (nodes.Count > 0) {
            Node node = nodes[0];
            Console.Write("{0} ", node.key);

            if (node.left != null) {
                nodes.Add(node.left);
            }
            if (node.right != null) {
                nodes.Add(node.right);
            }

            nodes.RemoveAt(0);
        }

        // clear trailing "%" character
        Console.WriteLine("");
    }

    public Node? RecursiveFind(int target)
    {
        if (root == null)
        {
            return null;
        }
        return RFind(target, root);
    }

    public Node? RFind(int target, Node branch)
    {
        if (branch.key == target)
        {
            return branch;
        }
        else if (target < branch.key)
        {
            if (branch.left != null)
            {
                return RFind(target, branch.left);
            }
            else return null;
        }
        else
        {
            if (branch.right != null)
            {
                return RFind(target, branch.right);
            }
            else return null;
        }
    }

    public Node? IterativeFind(int target)
    {        
        if(root == null) { return null; }
        else
        {
            Node branch = root;
            while (true)
            {
                if (target == branch.key)
                {
                    return branch;
                }
                else if (target < branch.key)
                {
                    if (branch.left != null)
                    {
                        branch = branch.left;
                    }
                    else return null;
                }
                else
                {
                    if (branch.right != null)
                    {
                        branch = branch.right;
                    }
                    else return null;
                }
            }
        }
    }

}






















