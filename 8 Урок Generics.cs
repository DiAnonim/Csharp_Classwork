using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

class Program
{
    static void Main()
    {
        Group<Person> group = new Group<Person>();

        Senior s1 = new("S1", "S", 63);
        Senior s2 = new("S2", "S", 55);
        Senior s3 = new("S3", "S", 59);
        Senior s4 = new("S4", "S", 70);

        Teenager t1 = new("T", "T");

        group.Add(s1);
        group.Add(t1);

        Family f1 = new Family();
        f1.Add(s1);
        f1.Add(s2);
        f1.Add(s3);
        f1.Add(s4);
        f1.Add(t1);

        /*foreach (Person p in f1.People)
        {
            WriteLine(p.fname);
        }*/

        foreach (Person p in f1)
        {
            WriteLine(p.SayHello());
            
        }

        foreach (Person p in f1.GetPeople(60))
        {
            WriteLine(p.SayHello());

        }
    }

    interface IVaccianble { }


    class Person
    {
        public string fname;
        public string lname;
        public int Age;

        public Person(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public Person(string fname, string lname, int age = 0)
        {
            this.fname = fname;
            this.lname = lname;
            Age = age;
        }

        public string SayHello()
        {
            string hello = $"Hello I'm {fname} ";
            if (Age > 0) hello += " I'm at " + Age.ToString();
            return hello;
        }

    }

    class Childe : Person
    {
        public Childe(string f, string l) : base(f, l) { }
    }
    class Tolder : Person
    {
        public Tolder(string f, string l) : base(f, l) { }
    }
    class Teenager : Person
    {
        public Teenager(string f, string l) : base(f, l) { }
    }
    class Adult : Person
    {
        public Adult(string f, string l) : base(f, l) { }
    }

    class Senior : Person
    {
        public Senior(string f, string l, int a) : base(f, l, a) { }
    }

    class Family
    {
        public List<Person> People;

        public Family()
        {
            People = new List<Person>();
        }

        public void Add(Person person)
        {
            People.Add(person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < People.Count; i++)
            {
                yield return People[i];
            }
        }

        public IEnumerable<Person> GetPeople(int minAge)
        {
            for (int i = 0; i < People.Count; i++)
            {
                if (minAge <= People[i].Age)
                {
                    yield return People[i];
                }
            }
        }

    }

    class Group<T> 
    {
        List<T> people;

        public Group()
        {
            people = new List<T>();
        }

        public void Add(T person)
        {
            people.Add(person);
        }
    }
}


