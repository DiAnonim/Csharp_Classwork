using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

public class Program
{

    public static void Main()
    {
        Week vs = new(0);
        WriteLine($"{vs.days[vs.index]}");
        vs++;
        WriteLine($"{vs.days[vs.index]}");
    }
}

class Week
{
    public string[] days;
    public int index;

    public Week(int index)
    {
        this.index = index;
        this.days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
    }

    public string this[int index]
    {
        get => days[index];
        set => days[index] = value;
    }

    public static Week operator ++(Week a)
    {
        a.index++;
        return a;
    }

}