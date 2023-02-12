class Program
{
    public static void Main (string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        string input = Console.ReadLine();

        int length = input.Length;
        int count = 0;
        for (int i = 0; i < length - 1; i++)
        {
            if (input[i] == input[i+1])
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}