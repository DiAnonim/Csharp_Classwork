using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

public class Program
{

    public static void Main()
    {
        Card jh = new("Jack", "Hearts", 11);
        Card qh = new("Queen", "Hearts", 12);

        // напишите метод который в качестве входных данных принимает
        // две карты и выдает какая из них старше

        /*if (jh > qh)
            WriteLine($"This card {jh.name} {jh.Mast} is bigger");
        WriteLine($"This card {qh.name} {qh.Mast} is bigger");*/

        // напишите перегрузку оператора ++ th++ -> jh j++ -> qh
        
        qh++;
        WriteLine($"{jh.name} {jh.Mast}");
        jh--;
        WriteLine($"{jh.name} {jh.Mast}");
    }

    class Card
    {
        public string name;
        public string Mast;
        public int val;
        public string[] masCard;

        public Card(string name, string mast, int value)
        {
            this.name = name;
            Mast = mast;
            this.val = value;
            masCard = new string[] { "A", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        }

        public static bool operator >(Card a, Card b)
        {
            return a.val > b.val;
        }

        public static bool operator <(Card a, Card b)
        {
            return a.val < b.val;
        }

        public static Card operator ++(Card a)
        {
            if (a.val < 13)
            {
                a.val++;
                a.name = a.masCard[a.val-1];
            }
            return a;
        }
        
        public static Card operator --(Card a)
        {
            if (a.val > 1)
            {
                a.val--;
                a.name = a.masCard[a.val - 1];
            }
            return a;
        }


    }


}

