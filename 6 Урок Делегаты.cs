using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

class Program
{
    static void Main()
    {
        Del DDI = new(DoubInt);
        DDI += PrintInt;
        int a = 10;

        foreach (Del b in DDI.GetInvocationList())
        {
            Console.WriteLine(b(a));
        }

        List<Student> group = new List<Student>
    {
         new Student {
         FirstName = "John",
         LastName = "Miller",
         },
         new Student {
         FirstName = "Candice",
         LastName = "Leman",
         },
         new Student {
         FirstName = "Joey",
         LastName = "Finch",
         }
    };

        Teacher teacher = new Teacher();

        teacher.examEvent += group[0].SolveExamTaskA;
        teacher.examEvent += group[1].SolveExamTaskB;
        teacher.examEvent += group[2].SolveExamTaskC;

        teacher.Exam("Task");
    }


    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SolveExamTaskA(string task)
        {
            WriteLine($"Student {LastName} solved the {task} on A");
        }
        public void SolveExamTaskB(string task)
        {
            WriteLine($"Student {LastName} solved the {task} on B");
        }
        public void SolveExamTaskC(string task)
        {
            WriteLine($"Student {LastName} solved the {task} on C");
        }
    }

    public delegate void ExamDelegate(string t);

    class Teacher
    {
        public event ExamDelegate examEvent;

        public void Exam(string task)
        {
            if (examEvent != null)
            {
                examEvent(task);
            }
        }
    }

    public delegate int Del(int x);
    static public int DoubInt(int b)
    {

        return b *= 5;
    }

    static public int PrintInt(int b)
    {
        return b *= 2;
    }
}
