using System;
using static System.Console;
using Russian;
using Japan;
using England;


//Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран.
//Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.

public class Program
{

    public static void Main()
    {
        Russian.Moscow st1 = new Moscow("Moscow", 146980061);
        Japan.Tokyo st2 = new Tokyo("Tokyo", 13988129);
        England.London st3 = new London("London", 56489800);

        int max = st1.population;
        if (max < st2.population)
            max = st2.population;
        else if (max < st3.population)
            max = st3.population;

        if (max == st1.population)
            Write($"Больше всего население в {st1.Name}");
        else if (max == st2.population)
            Write($"Больше всего население в {st2.Name}");
        else if (max == st3.population)
            Write($"Больше всего население в {st3.Name}");

    }

}

namespace Russian
{
    public class Moscow
    {
        public string Name;
        public int population;
        public Moscow(string name, int population)
        {
            Name = name;
            this.population = population;
        }
    }
}

namespace Japan
{
    public class Tokyo
    {
        public string Name;
        public int population;
        public Tokyo(string name, int population)
        {
            Name = name;
            this.population = population;
        }
    }
}

namespace England
{
    public class London
    {
        public string Name;
        public int population;
        public London(string name, int population)
        {
            Name = name;
            this.population = population;
        }
    }
}