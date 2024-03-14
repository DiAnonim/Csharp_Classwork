using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

class Program
{
    static void Main()
    {
        Point point_a = new Point
        {
            X = 10,
            Y = 0
        };


        Point point_b = new Point
        {
            X = 0,
            Y = 0
        };

        if (point_a && point_b)
        {
            Console.WriteLine("both true");
        }
        else
        {
            Console.WriteLine("one is false");
        }

        if (point_a || point_b)
        {
            Console.WriteLine("one is true");
        }
        else
        {
            Console.WriteLine("none is true");
        }

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static bool operator true(Point p)
        {
            Console.WriteLine("true operator");
            return p.X != 0 || p.Y != 0 ? true : false;
        }
        public static bool operator false(Point p)
        {
            Console.WriteLine("false operator");
            return p.X == 0 && p.Y == 0 ? true : false;
        }

        public static Point operator &(Point a, Point b)
        {
            Console.WriteLine("and operation");
            return new Point();
        }

        public static Point operator |(Point a, Point b)
        {
            Console.WriteLine("or operation");
            return new Point();
        }

        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}.";
        }
    }
}