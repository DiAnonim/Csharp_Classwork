using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
        Student studentA = new Student("Altynbek", "Zhabykov", "221-1");
        Student studentB = new Student("Almas", "To", 3.5f);
        Student studentC = new Student("Aliya", "Ko");
        Student[] students = { studentA, studentB, studentC };
        foreach (Student st in students)
        {
            WriteLine(st.sayHello());
        }

        // WriteLine(studentA.sayHello());

        Person p1 = new Person("Homer", "Simpson");
        Person p2 = new Person("Marsh", "Simpson");
        Person p3 = new Person("Bard", "Simpson");
        Car maz = new Car("123ASD001", p1);
        maz.Model = "Mazzerati";

        p1.family.Add(p2);
        p1.family.Add(p3);

        foreach (Person rel in p1.family)
        {
            WriteLine(rel.sayHello());
        }


        WriteLine(maz.driver.sayHello());
        WriteLine(maz.Model);

    }

    public class Person
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public int age;
        public bool canDrive;
        public List<Person> family;

        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
            family = new List<Person>();
        }

        public string sayHello()
        {
            return firstName + ", " + lastName;
        }

    }

    public class Car
    {
        string plate;
        string model { get; set; } = "unspecified";
        public Person driver;
        public Car(string _plate, Person _driver)
        {
            plate = _plate;
            driver = _driver;
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 3)
                    model = value;
            }
        }

        public string getInfo()
        {
            return "Модель = " + Model;
        }
    }

    public class Student
    {
        //public int studentIndex;
        public string firstName;
        public string lastName;
        public string group;
        public float grade;
        public Student(string firstName, string _lname) : this(firstName, _lname, "unknown", 3f) { }
        public Student(string firstName, string _lname, float _grade) : this(firstName, _lname, "unknown", _grade) { }
        public Student(string firstName, string _lname, string _group) : this(firstName, _lname, _group, 3f) { }

        public Student(string firstName, string _lname, string _group, float _grade)
        {
            this.firstName = firstName;
            lastName = _lname;
            group = _group;
            grade = _grade;
        }

        public void Print()
        {
            WriteLine($"Студент {firstName} {lastName}");
        }

        public string sayHello()
        {
            return firstName + ", " + lastName;
        }
    }
}
