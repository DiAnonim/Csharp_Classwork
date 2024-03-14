using System;
using static System.Console;

public class Program
{
    //public static void Main()
    //{
    //    int numb = 1;

    //    float x = 6.5F;
    //    int y = 5;
    //    float A = y + x;
    //    int B = (int)A;
    //    Console.WriteLine(B);

    //    Write("Enter number ");
    //    int inp = Int32.Parse(ReadLine());

    //    NumbDouble(ref inp);

    //    if (inp > 0 && inp % 2 != 0)
    //    {
    //        Console.ForegroundColor = ConsoleColor.DarkBlue;
    //    }
    //    else
    //    {
    //        Console.ForegroundColor = ConsoleColor.DarkRed;
    //    }

    //    for (int i = 0; i < 5; i++)
    //    {
    //        WriteLine($"Your number is bigger {inp} than 0");
    //    }


    //    //ForegroundColor = inp > 0 ? ConsoleColor.DarkBlue : ConsoleColor.DarkRed;

    //    WriteLine("good bye");
    //    Console.ResetColor();
    //}

    //public static int NumbDouble(ref int a)
    //{
    //    return a *= 2;
    //}
    //public static void Main()
    //{
    //    ForegroundColor = ConsoleColor.DarkBlue;
    //    WriteLine("It's easy to win forgiveness for being wrong; being right is what gets you into real trouble.");
    //    Console.ResetColor();
    //}

    //public static void Main()
    //{
    //    Write("Enter 5 number ");
    //    int[] mas = new int[5];

    //    for (int i = 0; i < 5; i++)
    //    {
    //        mas[i] = Int32.Parse(ReadLine());
    //    }
    //    int res = 0;

    //    for (int i = 0; i < 5; i++)
    //    {
    //        res += mas[i];
    //    }

    //    WriteLine($"Сумма = {res}");
    //    res = 1;
    //    for (int i = 0; i < 5; i++)
    //    {
    //        res *= mas[i];
    //    }

    //    WriteLine($"Произведение = {res}");

    //    res = mas[0];
    //    for (int i = 1; i < 5; i++)
    //    {
    //        if (res < mas[i])
    //            res = mas[i];
    //    }
    //    WriteLine($"Max = {res}");

    //    res = mas[0];
    //    for (int i = 1; i < 5; i++)
    //    {
    //        if (res > mas[i])
    //            res = mas[i];
    //    }
    //    WriteLine($"Min = {res}");
    //}

    //    Задание 3
    //Пользователь с клавиатуры вводит шестизначное число.
    //Необходимо перевернуть число и отобразить результат.
    //Например, если введено 341256, результат 652143.
    public static void Main()
    {
        Write("Enter number ");
        int numb = Int32.Parse(ReadLine());

        WriteLine($"Number = {numb}");
        int res = 0;

        for (int i = 0; i < 6; i++)
        {
            res = numb %= 10;
            numb /= 10;
            WriteLine(res);
        }
    }
}
