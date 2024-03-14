using System;
using System.Collections.Generic; // коллекции
using System.Collections;
using static System.Console;
using System.IO; // работа с файлами
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;





class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree(99, null);
        tree.add(5);
        tree.add(99);
        tree.add(99);
        tree.add(5);
        tree.add(99);
        tree.add(99);
        tree.add(99);
        tree.add(5);
        tree.add(99);
        tree.add(33);
        tree.add(99);

        

        /* tree.remove(33);
         tree.remove(17);
         tree.print();*/

        tree.Search1(33);
        tree.Print();



    }
}

public class Node
{
    public int key;
    public int Cnt;
    public Node Parent;
    public Node Left, Right;
    public Node() { }
    public Node(int key, Node parent = null)
    {
        this.key = key;
        this.Parent = parent;
    }
};

public class BinaryTree : Node
{
    private Node Root;
    private int cnt;
    private BinaryTree parent, left, right;
    private List<int> listForPrint = new List<int>();

    public BinaryTree(int val, BinaryTree parent)
    {
        base.key = val;
        this.parent = parent;
    }

    public void add(int val)
    {
        if (val.CompareTo(this.key) < 0)
        {
            if (this.left == null)
            {
                this.left = new BinaryTree(val, this);
            }
            else if (this.left != null)
                this.left.add(val);
        }
        else
        {
            if (this.right == null)
            {
                this.right = new BinaryTree(val, this);
            }
            else if (this.right != null)
                this.right.add(val);
        }
    }

  

    /*public int Recount(BinaryTree t, int num)
    {
        int count = 0;

        if (t.left != null)
        {
            count += Recount(t.left, num);
            if (t.key == num)
                count++;
        }
        count++;
        if (t.right != null)
        {
            count += Recount(t.right, num);
            if (t.key == num)
                count++;
        }
        
        return count;
    }*/

    public Node Search1(int num) { return Search1(Root, num); }
    private Node Search1(Node pNode, int numb)
    {
        while (pNode != null)
        {
            if (pNode.key > numb) { pNode = pNode.Left; }

            else if (pNode.key < numb) { pNode = pNode.Right; }
            else { return pNode; }
        }
        return null;
    }

    public void Print() { Print(Root); }
    public void Print(Node pNode)
    {
        if (pNode == null) { return; }
        Print(pNode.Left);
        WriteLine($"{pNode.Cnt} : {pNode.key}");
        Print(pNode.Right);
    }



    private void _print(BinaryTree node)
    {
        if (node == null) return;
        _print(node.left);
        listForPrint.Add(node.key);
        Console.Write(node + " ");
        if (node.right != null)
            _print(node.right);
    }
    public void print()
    {
        listForPrint.Clear();
        _print(this);
        Console.WriteLine();
    }

    public override string ToString()
    {
        return key.ToString();
    }
}

