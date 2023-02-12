class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        //while (num > 0)
        //{
        //    num = num - 5;
        //    count++;
        //}
        count = num / 5;
        if (count * 5 < num) count++;

        Console.WriteLine(count);
    }
}
