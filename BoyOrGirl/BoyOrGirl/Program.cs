public class Program
{
    public  static void Main(string[] args)
    {
        char[] array = new char[26];
        string input = "wjmzbmr";
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            Console.WriteLine(array[c]);
            
            
        }
        //Console.WriteLine(count);

    }
}