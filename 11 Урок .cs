using System;
using System.Collections.Generic; // коллекции
using System.Collections;
using static System.Console;
using System.IO; // работа с файлами
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;


//Напишите консольное приложение "контакты". Для сохранения контактов в файл.


class Program
{
    static void Main()
    {

        LinkedList list = new(1);
        ListNode a = new(1);
        ListNode b = new(2);


        ListNode d = new(4);
        ListNode c = new(3);
        ListNode e = new(5);

        list.Append(2);
        list.Append(3);
        list.Append(4);
        list.Append(5);

        list.Print();


        /*string path = @"D:\test.xml";

        Person p1 = new("Anna", "8732131564");
        Person p2 = new("Alice", "873203541");

        List<Person> list = new List<Person>();
        list.Add(p1);
        list.Add(p2);

        writeXML(list, path);
        readXML(list, path);

        while (true)
        {
            WriteLine("Считать или записать? [r/w]");
            string cmd = ReadLine();

            switch (cmd)
            {
                case "rl":
                    readXML(list,path);
                    break;
                case "r":
                    List<Person> family = readXML(list, path);
                    foreach (Person person in family)
                    {
                        WriteLine(person.ToString());
                    }
                    break;
                case "w":
                    WriteLine("ФИО:");
                    string fio = ReadLine();
                    WriteLine("Телефон:");
                    string phone = ReadLine();
                    Person p = new(fio, phone);
                    AppendToXml(p, path);
                    break;
            }
        }*/


    }


    public static void AddFile(string Path, Person p)
    {

        using (FileStream fs = new FileStream(Path, FileMode.Append))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
            {
                WriteLine("Enter the data to write to the file: ");
                string text = ReadLine();

                sw.WriteLine(text);

                WriteLine("\nData recorded!");
                sw.Close();
            }
        }
    }

    public static void writeXML(List<Person> val, string path) // сериализация
    {
        XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
        try
        {
            using (Stream fs = File.OpenWrite(path))
            {
                xml.Serialize(fs, val);
            }
        }
        catch (Exception ex) { }
    }

    static void AppendToXml(Person p, string path)
    {
        List<Person> family = null;
        family = readXML(family, path);
        family.Add(p);
        writeXML(family, path);
    }

    public static List<Person> readXML(List<Person> val, string path)// десериализация
    {
        val = null;
        using (Stream fs = File.OpenRead(path))
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            val = (List<Person>)xml.Deserialize(fs);



        }
        return val;
        /*foreach (Person p in val)
        {
            WriteLine(p.ToString());
        }*/
    }

    public static void ReaderFile(string Path)
    {
        using (FileStream fs = new FileStream(Path, FileMode.Open))
        {
            using (StreamReader sw = new StreamReader(fs, Encoding.Unicode))
            {
                string text = sw.ReadToEnd();


                WriteLine(text);

                WriteLine("Text from file: ");
                Write($"\n{text}");
                sw.Close();
            }
        }
    }

    public static void CreateFile(string Path)
    {
        using (FileStream fs = new FileStream(Path, FileMode.Create))
        {
            fs.Close();
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

    static public ListNode ReverseNode(ref ListNode node)
    {
        ListNode prevNode = null;
        ReverseNode(ref prevNode, ref node);
        return prevNode;
    }

    static public void ReverseNode(ref ListNode prevNode, ref ListNode node)
    {
        if (node == null) return;
        ListNode nextNode = node.Next;
        node.Next = prevNode;
        prevNode = node;
        node = nextNode;

        ReverseNode(ref prevNode, ref node);
    }

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
        public void Append(int value)
        {
            ListNode last = head;
            while (last.Next != null) { last = last.Next; }
            last.Next = new ListNode(value);
        }

        public void Print()
        {
            while (head != null)
            {
                Write($"{head.Value}");
                head = head.Next;
                if(head != null)
                WriteLine($"->{head.Value}");
            }
        }

       
    }


}

[Serializable]
public class Person
{
    public string name;
    public string phone;

    public Person() { }
    public Person(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }

    public override string ToString()
    {
        return $"Name: {name}, Phone: {phone}";
    }
}
// Person almas = new()....
// {"name":"Almas","phone":"874565454"}
// xml
// <person>
//     <name>Almas</name>
//     <phone>874565454</phone>
// </person>

/*foreach (var item in text)
{
    sw.Write($"{item} ");
}
*/