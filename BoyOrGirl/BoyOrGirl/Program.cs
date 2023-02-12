

using System;

public class Program
{
    public static void Main(string[] args)
    {
        char[] array = new char[26];
        string input = "wjmzbmr";
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            array[input[i]] = c;


        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }


    }
}