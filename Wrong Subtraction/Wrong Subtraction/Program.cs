class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        var input = int.Parse(data[0]); //first integer
        var times = int.Parse(data[1]);

        //int input = Convert.ToInt32(Console.ReadLine());
        //int times = Convert.ToInt32(Console.ReadLine());

        
        while(times > 0) {
            int value = input % 10;
            if(value > 0)
            {
                input = input - 1;
            }
            if(value == 0)
            {
                input = input / 10;
            }
            times--;
        }
        Console.WriteLine(input);

    }
}