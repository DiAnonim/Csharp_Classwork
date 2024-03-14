using System;
using static System.Console;

public class Program
{

    public static void Main()
    {
        /*Human alf = new Human("Alf", "Zong", "01.01.1970");*/
        // Human alf = new Human();
        //alf.Name = "Alf";
        //alf.sayHello();

        /*Employee emp = new Employee("Homer", "Simpson", "02.03.1975", 1500);
        Employee emp1 = new Employee();*/

        Scientist emp = new Scientist();
        Scientist emp1 = new Scientist();
        Specialist emp2 = new Specialist();


        List<Employee> emps = new List<Employee>();
        emps.Add(emp);
        emps.Add(emp1);
        emps.Add(emp2);

        /*foreach(Employee e in emps)
        {
            e.sayHello();
        }*/

        Manager almas = new Manager();
        almas.sayHello();

        /*almas.ListOfWorkers.Add(emp);
        almas.ListOfWorkers.Add(emp1);*/

        foreach (IWorker employee in emps)
        {
            almas.ListOfWorkers.Add(employee);
        }


        foreach (IWorker iw in almas.ListOfWorkers)
        {
            WriteLine(iw.Work());
        }

    }
}

abstract class Human : Object
{
    int id;
    protected string f_name;
    protected string l_name;
    protected string b_day;
    ~Human() { }

    public Human() : this("Jhon", "Doe", "01.01.1987") { }

    public Human(string fname, string lname) : this(fname, lname, "01.01.2000") { }

    public Human(string fname, string lname, string bday)
    {
        this.f_name = fname;
        this.l_name = lname;
        this.b_day = bday;
    }

    public string Name
    {
        get { return f_name; }
        set { f_name = value; }
    }

    public virtual void sayHello()
    {
        WriteLine($"id: {id}, fname: {f_name}, lname: {l_name}, bday: {b_day}");
    }

    public abstract void SayGoodBye();
}


class Employee : Human
{
    double salary;
    public Employee() : base() { }
    public Employee(string fname, string lname, string bday, double salary) : base(fname, lname, bday)
    {
        this.salary = salary;
    }
    ~Employee() { }

    public override void sayHello()
    {
        //base.sayHello();
        //WriteLine($"salary: {salary}");
        WriteLine($"fname: {f_name}, lname: {l_name}, bday: {b_day}, salary: {salary}");
    }

    public override void SayGoodBye() { }

}

sealed class Tutor : Human
{
    public override void SayGoodBye() { }
}


class Scientist : Employee, IWorker
{
    bool isWorking;
    public Scientist() : base() { }
    public bool IsWorking
    {
        get { return isWorking; }
    }
    public string Work()
    {
        return "I am managing internal functions, please, do not disturb";
    }
}

class Manager : Employee, IWorker, IManager
{
    bool isWorking;
    List<IWorker> listOfWorkers;
    public Manager() : base()
    {
        listOfWorkers = new List<IWorker>();
    }

    public bool IsWorking
    {
        get { return isWorking; }
    }
    public string Work()
    {
        return "I am managing internal functions, please, do not disturb";
    }

    public List<IWorker> ListOfWorkers
    {
        get { return listOfWorkers; }
        set { listOfWorkers = value; }
    }
    public void Organize() { }
    public void MakeBudget() { }
    public void Control() { }
}


class Specialist : Employee, IWorker
{
    bool isWorking;
    public Specialist() : base() { }
    public bool IsWorking
    {
        get { return isWorking; }
    }
    public string Work()
    {
        return "I am managing internal functions, please, do not disturb";
    }
}

interface IWorker
{
    bool IsWorking { get; }
    string Work();
    /*string this[int index]
    {
        get;
        set;
    }*/
}

interface IManager
{
    List<IWorker> ListOfWorkers { get; set; }
    void Organize();
    void MakeBudget();
    void Control();

    //void callWorker();
}

/*class Learner : Human { }


class SchoolChild : Learner { }

class Student : Learner { }

*/