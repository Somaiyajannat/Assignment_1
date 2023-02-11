
public class Program
{
    public static void Main(String[] args)
    {
        string input;
        input = Console.ReadLine();
        int length = input.Length - (input.Length / 2);

       

        int[] array = new int[length];

        int pos = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != '+')
            {
                int value = Convert.ToInt32(input[i]);
                array[pos] = value - 48;
                pos++;
            }
        }

        Array.Sort(array);

        string output = "";
        for (int i = 0; i < array.Length; i++)
        {
            char c = (char)(array[i] + 48);
            Console.Write(c);
            if (i != array.Length - 1)
            {
                Console.Write("+");
            }
        }

    }
}