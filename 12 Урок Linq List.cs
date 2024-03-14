using System;

public class Program
{
    public class LinkedList
    {
        ListNode head;

        public LinkedList(int n)
        {
            head = new ListNode(n);
        }
        public void Add(int value)
        {
            ListNode n = new ListNode(value);
            n.Next = head;
            head = n;
        }
        public void Insert(int index, int value)
        {
            int startIndex = 0;
            int endIndex = Count();

            if (index < startIndex || index > endIndex) return;

            ListNode last = head;
            while (last.Next != null)
            {
                last = last.Next;
                startIndex++;
                if (startIndex == index) break;
            }

            ListNode nextNode = last.Next;
            last.Next = new ListNode(value, nextNode);

        }
        public void Append(int value)
        {
            ListNode last = head;
            while (last.Next != null) { last = last.Next; }
            last.Next = new ListNode(value);
        }

        public int Count()
        {
            int count = 0;
            ListNode last = head;
            while (last != null)
            {
                last = last.Next;
                count++;
            }
            return count;
        }

        public void Print()
        {
            while (head != null)
            {
                Console.WriteLine($"{head.Value} ->");
                head = head.Next;
            }
        }
    }
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int _value, ListNode _next = null)
        {
            Value = _value;
            Next = _next;
        }
    }
    public ListNode ReverseList(ref ListNode node)
    {
        ListNode previousNode = null;
        ReverseNode(ref previousNode, ref node);
        return previousNode;
    }

    public void ReverseNode(ref ListNode prevNode, ref ListNode node)
    {
        if (node == null) return;

        ListNode nextNode = node.Next;
        node.Next = prevNode;
        prevNode = node;
        node = nextNode;

        ReverseNode(ref prevNode, ref node);
    }

    public static void Main()
    {

        LinkedList ll = new(1);
        ll.Append(2);
        ll.Append(3);
        ll.Append(4);
        ll.Add(5);
        ll.Insert(2, 6);

        Console.WriteLine(ll.Count());

        ll.Insert(99, 99);
        ll.Print();


        // a -> b -> c -> d -> null
        // d -> c -> b -> a -> null

        /*ListNode d = new(4);
        ListNode c = new(3, d);
        ListNode b = new(2, c);
        ListNode a = new(1, b);

        List<ListNode> list = new List<ListNode>();
        list.Add(a);
        list.Add(b);
        list.Add(c);
        list.Add(d);


        foreach (ListNode node in list)
        {
            Console.Write(node.Value);
            if (node.Next != null) Console.Write($"->{node.Next.Value}");
            Console.Write("\n");
        }

        Program p = new();
        p.ReverseList(ref a);

        foreach (ListNode node in list)
        {
            Console.Write(node.Value);
            if (node.Next != null) Console.Write($"->{node.Next.Value}");
            Console.Write("\n");
        }*/
    }
}