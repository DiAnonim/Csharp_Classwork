using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

/*Консольное приложение:
1.Принимает N(50 > N > 30) количество элементов в коллекции
2. Заполняет коллекцию случайными числами от -50 до +50
3. Выдает на экран количество и перечисление положительных элементов коллекции
*/
public class Program
{

    public static void Main()
    {
        var rand = new Random();
        int size = rand.Next(30, 50);
        ArrayList mas1 = new ArrayList(size);
        var rand2 = new Random();
        for (int i = 0; i < size; i++)
        {
            mas1.Add(rand2.Next(-50, 50));
        }
        WriteLine($"Size:{size}");
        foreach (int i in mas1)
        {
            if (i > 0)
                WriteLine(i);
        }
    }
}