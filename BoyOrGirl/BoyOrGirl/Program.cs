

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[130];
        string input = Console.ReadLine();

       
        for (int i = 0; i < input.Length; i++)
        {
            int value = input[i];
            if(array[value] == 0)
            {
                array[value]++;
            }
        }
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] != 0)
            {
                // Console.WriteLine( i + " "+array[i]);
                count++;
            }
            
        }
        if ((count %2) == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        } else
        {
            Console.WriteLine("IGNORE HIM!");
        }
      


    }
}