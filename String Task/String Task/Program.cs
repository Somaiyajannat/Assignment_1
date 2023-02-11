// 118/ String Task

public class program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != 'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u' && input[i] != 'y' && input[i] != 'A' && input[i] != 'E' 
                && input[i] != 'I' && input[i] != 'O' && input[i] != 'U' && input[i] != 'Y')
            {
                char b = char.ToLower(input[i]);
                Console.Write("." + b);
            }
        }
    }
}