using System;
using System.IO;

class Program
{
    static string StringReverse(string str)
    {
        string s = String.Empty;


        for (int i = str.Length - 1; i >= 0; i--)

        {
            s = s + str[i];
        }

        return s;
    }

    static void Main(string[] args)
    {
        //var text = Console.ReadLine();

        string path = @"D:\FFF.txt";
        string text = System.IO.File.ReadAllText(path);

        Console.WriteLine("Исходная строка:" + text);

        File.AppendAllText(path, Environment.NewLine);
        File.AppendAllText(path, StringReverse(text));

        Console.WriteLine("Развёрнутая строка:" + StringReverse(text));
        Console.ReadKey();
    }
}