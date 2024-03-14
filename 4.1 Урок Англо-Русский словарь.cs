using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;

/*Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов — названий 
стран на русском и английском языках. Пользователь 
должен иметь возможность выбирать направление перевода и запрашивать перевод
*/
public class Program
{

    public static void Main()
    {
        Hashtable hash = new Hashtable();
        hash.Add("Россия", "Russian");
        hash.Add("Яблоко", "Apple");
        hash.Add("Стул", "Chair");
        hash.Add("Сыр", "Cheese");
        hash.Add("Дверь", "Door");


        WriteLine("Enter the word you are looking for");
        string word = ReadLine();
        ICollection key = hash.Keys;

        foreach (string s in key)
        {
            if (s == word)
                WriteLine(s + ": " + hash[s]);
            if ((string)hash[s] == word)
            WriteLine(hash[s] + ": " + s);

        }

    }
}